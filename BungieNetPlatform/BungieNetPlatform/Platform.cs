using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.ServiceModel;
using System.Text.RegularExpressions;
using BungieNetPlatform;
using Newtonsoft.Json;
using BungieNetPlatform.Responses;
using BungieNetPlatform.Enums;

namespace BungieNetPlatform {

	[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
	public class Platform : IPlatform {

		private async Task<JObject> AuthRequest(string path, string method, HttpContent data, RequestingUser u) {

			using(HttpClientHandler handler = new HttpClientHandler())
			using(HttpClient client = new HttpClient(handler)) {

				HttpResponseMessage msg = null;
				string str;

				if(u != null) {
					handler.UseCookies = true;
					handler.CookieContainer = new CookieContainer();
					u.Cookies.ToList().ForEach(c => handler.CookieContainer.Add(c));
					client.DefaultRequestHeaders.Add("x-csrf", u.CsrfToken);
				}
				else {
					handler.UseCookies = false;
				}

				if(method.ToUpper() == WebRequestMethods.Http.Get.ToUpper()) {
					msg = await client.GetAsync(BungieNet.PlatformPath + path);
				}
				else if(method.ToUpper() == WebRequestMethods.Http.Post.ToUpper()) {
					msg  = await client.PostAsync(BungieNet.PlatformPath + path, data);
				}

				str = await msg.Content.ReadAsStringAsync();

				return JObject.Parse(str);

			}

		}

		private async Task<JObject> NoAuthRequest(string path, RequestingUser u) {

			HttpResponseMessage msg;
			string str;

			using(HttpClientHandler handler = new HttpClientHandler())
			using(HttpClient client = new HttpClient(handler)) {

				if(u != null) {
					handler.CookieContainer = new CookieContainer();
					u.Cookies.ToList().ForEach(c => handler.CookieContainer.Add(c));
				}

				handler.UseCookies = true;

				msg = await client.GetAsync(BungieNet.PlatformPath + path);
				str = await msg.Content.ReadAsStringAsync();

				return JObject.Parse(str);

			}

		}





		public async Task<GetTopicsResponse> GetTopics(
			RequestingUser u,
			IEnumerable<Tag> tags = null,
			int? page = null,
			int? groupId = null,
			bool asUser = false,
			ForumTopicsCategoryFilters category = ForumTopicsCategoryFilters.None,
			ForumTopicsSort sort = ForumTopicsSort.Latest,
			ForumTopicsQuickDate date = ForumTopicsQuickDate.LastYear,
			int itemsPerPage = BungieNet.ForumItemsPerPage
			) {

				string path = string.Format(
					"/Forum/GetTopicsPaged/{0}/{1}/{2}/{3}/{4}/{5}/?lc=en&tagstring={6}",
					page ?? 0,
					itemsPerPage,
					groupId ?? 0,
					(int)sort,
					(int)date,
					(int)category,
					tags != null ? HttpUtility.UrlEncode(string.Join(",", tags)) : ""
				);

				JObject j = await NoAuthRequest(path, u);
				return new GetTopicsResponse(j);

		}

		public async Task<GroupResponse> GetGroup(
			RequestingUser u,
			int groupId
			) {

				JObject j;

				if(u != null) {
					j = await AuthRequest(
						string.Format("/Group/{0}/", groupId),
						WebRequestMethods.Http.Get,
						null,
						u
					);
				}
				else {
					j = await NoAuthRequest(
						string.Format("/Group/{0}/", groupId),
						null
					);
				}

				return new GroupResponse(j);

		}

		public async Task<ConversationResponse> GetConversation(
			RequestingUser u,
			int conversationId,
			int page = 1
			) {

				JObject j = await AuthRequest(
					string.Format("/Message/GetConversationThreadV3/{0}/{1}/", conversationId, page),
					WebRequestMethods.Http.Get,
					null,
					u
				);

				return new ConversationResponse(j);

		}


		public async Task<CreatePostResponse> CreateTopic(
			RequestingUser u,
			string subject,
			string body,
			string urlOrImage = null,
			int? groupId = null,
			Tag tagCategory = null,
			IEnumerable<Tag> tags = null
			) {

				JObject o = new JObject();
				o["body"] = body;
				o["category"] = 0;
				o["groupId"] = groupId ?? 0;
				o["isPrivateGroup"] = groupId.HasValue && groupId != 0;
				o["metadata"] = null;
				o["parentPostId"] = null;
				o["subTopicOverride"] = false;
				o["subject"] = subject;
				o["tagCategory"] = tagCategory != null ? tagCategory.Normalized : "0";
				o["tagInput"] = string.Join(",", tags);
				o["urlLinkOrImage"] = urlOrImage;

				JObject j = await AuthRequest(
					"/Forum/CreatePost/",
					WebRequestMethods.Http.Post,
					new StringContent(o.ToString()),
					u
				);

				return new CreatePostResponse(j);

		}

		public async Task<CreatePostResponse> PostReply(
			RequestingUser u,
			int parentPostId,
			string body,
			string media = "",
			int? groupId = null
			) {

				JObject o = new JObject();
				o["parentPostId"] = parentPostId;
				o["subTopicOverride"] = false;
				o["subject"] = "";
				o["body"] = body;
				o["tagInput"] = "";
				o["tagCategory"] = "0";
				o["category"] = 0;
				o["groupId"] = groupId ?? 0;
				o["isPrivateGroup"] = groupId.HasValue && groupId != 0;
				o["urlLinkOrImage"] = media;
				o["metadata"] = "";

				JObject j = await AuthRequest(
					"/Forum/CreatePost/",
					WebRequestMethods.Http.Post,
					new StringContent(o.ToString()),
					u
				);

				return new CreatePostResponse(j);

		}

		public async Task<GetCountsResponse> GetCounts(
			RequestingUser u
			) {
				JObject j = await AuthRequest("/User/GetCounts/", WebRequestMethods.Http.Get, null, u);
				return new GetCountsResponse(j);
		}

		public async Task<GetNotificationsResponse> CheckNotifications(
			RequestingUser u
			) {
				JObject j = await AuthRequest("/Notification/GetRecent/", WebRequestMethods.Http.Get, null, u);
				return new GetNotificationsResponse(j);
		}

		public async Task<SaveMessageResponse> WriteToWall(
			RequestingUser u,
			string body,
			int conversationId,
			string subject
			) {

				JObject post = new JObject();
				post["body"] = body;
				post["conversationId"] = conversationId.ToString();
				post["subject"] = subject;

				JObject j = await AuthRequest(
					"/Message/SaveMessageV3/",
					WebRequestMethods.Http.Post,
					new StringContent(post.ToString()),
					u
				);

				return new SaveMessageResponse(j);

		}

		public async Task<CurrentUserResponse> GetCurrentUser(
			RequestingUser u
			) {

				JObject j = await AuthRequest(
					"/User/GetBungieNetUser/",
					WebRequestMethods.Http.Get,
					null,
					u
				);

				return new CurrentUserResponse(j);

		}

		public async Task<GetMessagesResponse> GetMessages(
			RequestingUser u,
			int page = 1
			) {

				JObject j = await AuthRequest(
					string.Format("/Message/GetConversationsV4/{0}/", page),
					WebRequestMethods.Http.Get,
					null,
					u
				);

				return new GetMessagesResponse(j);

		}

		public async Task<FollowersResponse> GetFollowers(
			RequestingUser u,
			int memberId,
			int page = 1,
			int itemsPerPage = 50
			) {

				JObject j = await NoAuthRequest(
					string.Format(
						"/Activity/User/{0}/Followers/?itemsperpage={1}&currentpage={2}",
						memberId,
						itemsPerPage,
						page
					),
					u
				);

				return new FollowersResponse(j);

		}

		public async Task<GetUserResponse> GetUserById(
			RequestingUser u,
			int memberId
			) {

				JObject j = await NoAuthRequest(
					string.Format("/User/GetBungieNetUserById/{0}/", memberId),
					u
				);

				return new GetUserResponse(j);

		}





		//public async Task<JObject> LikePostAsync(RequestingUser u, int postId) {
			
		//	string path = string.Format("/Forum/RatePost/{0}/100/", postId);
		//	JObject j = await AuthRequest(path, WebRequestMethods.Http.Post, new StringContent("null"), true);
		//	CheckForExceptions(j);
		//	return j;

		//}

		//public async Task<JObject> VoteAsync(RequestingUser u, int postId, int optionIndex) {

		//	string path = string.Format("/Forum/Poll/Vote/{0}/{1}/", postId, optionIndex);
		//	JObject j = await AuthRequest(path, WebRequestMethods.Http.Post, new StringContent("null"), true);
		//	CheckForExceptions(j);
		//	return j;

		//}

		//public async Task<JObject> BlacklistAsync(RequestingUser u) {
		//	throw new NotImplementedException();
		//}

		//public async Task<JObject> SendMessageAsync(RequestingUser u, List<int> recipients, string body) {

		//	JObject o = new JObject();
		//	o["membersToId"] = string.Join(",", recipients);
		//	o["body"] = body;

		//	JObject j = await AuthRequest(
		//		"/Message/SaveMessageV2/",
		//		WebRequestMethods.Http.Post,
		//		new StringContent(o.ToString()),
		//		true
		//	);

		//	CheckForExceptions(j);
		//	return j;

		//}

		//public async Task<JObject> GetPostsAsync(int postId, int page = 0) {

		//	string path = string.Format("/Forum/GetPostsThreadedPaged/{0}/{1}/25/25/true/true/0/", postId, page);
		//	JObject j = await NoAuthRequest(path, true);
		//	CheckForExceptions(j);
		//	return j;

		//}


	}
}
