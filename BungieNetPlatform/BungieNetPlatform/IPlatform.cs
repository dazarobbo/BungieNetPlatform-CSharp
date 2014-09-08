using System.Collections.Generic;
using System.ServiceModel;
using BungieNetPlatform;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using BungieNetPlatform.Responses;
using BungieNetPlatform.Enums;

namespace BungieNetPlatform {

	[ServiceContract]
	public interface IPlatform {

		[OperationContract]
		Task<GetTopicsResponse> GetTopics(
			RequestingUser u,
			IEnumerable<Tag> tags = null,
			int? page = null,
			int? groupId = null,
			bool asUser = false,
			ForumTopicsCategoryFilters category = ForumTopicsCategoryFilters.None,
			ForumTopicsSort sort = ForumTopicsSort.Latest,
			ForumTopicsQuickDate date = ForumTopicsQuickDate.LastYear,
			int itemsPerPage = BungieNet.ForumItemsPerPage
			);

		[OperationContract]
		Task<GroupResponse> GetGroup(
			RequestingUser u,
			int groupId
			);

		[OperationContract]
		Task<ConversationResponse> GetConversation(
			RequestingUser u,
			int conversationId,
			int page = 1
			);

		[OperationContract]
		Task<CreatePostResponse> CreateTopic(
			RequestingUser u,
			string subject,
			string body,
			string urlOrImage = null,
			int? groupId = null,
			Tag tagCategory = null,
			IEnumerable<Tag> tags = null
			);
		
		[OperationContract]
		Task<CreatePostResponse> PostReply(
			RequestingUser u,
			int parentPostId,
			string body,
			string media = "",
			int? groupId = null
			);

		[OperationContract]
		Task<SaveMessageResponse> WriteToWall(
			RequestingUser u,
			string body,
			int conversationId,
			string subject
			);

		[OperationContract]
		Task<GetCountsResponse> GetCounts(
			RequestingUser u
			);

		[OperationContract]
		Task<GetNotificationsResponse> CheckNotifications(
			RequestingUser u
			);

		[OperationContract]
		Task<CurrentUserResponse> GetCurrentUser(
			RequestingUser u
			);

		[OperationContract]
		Task<GetMessagesResponse> GetMessages(
			RequestingUser u,
			int page = 1
			);

		[OperationContract]
		Task<FollowersResponse> GetFollowers(
			RequestingUser u,
			int memberId,
			int page = 1,
			int itemsPerPage = 50
			);

		[OperationContract]
		Task<User> GetUserById(
			RequestingUser u,
			int memberId
			);

	}
}
