using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web;

namespace BungieNetPlatform {

	[DataContract]
	public class Post {

		[DataMember]
		public int PostId;

		[DataMember]
		public int ParentPostId;

		[DataMember]
		public int TopicId;

		[DataMember]
		public int ThreadDepth;

		[DataMember]
		public int Category;

		[DataMember]
		public int AuthorMembershipId;

		[DataMember]
		public int? EditorMembershipId;

		[DataMember]
		public string RawSubject;

		[DataMember]
		public string Subject {
			get {
				return RawSubject ?? HttpUtility.HtmlDecode(RawSubject);
			}
			private set {
				//Do nothing, only here for serialization
			}
		}

		[DataMember]
		public string Body;

		[DataMember]
		public string UrlLinkOrImage;

		[DataMember]
		public DateTime CreationDate;

		[DataMember]
		public DateTime? LastModified;

		[DataMember]
		public DateTime? LastReplyDate;

		[DataMember]
		public int EditCount;

		[DataMember]
		public int ReplyCount;

		[DataMember]
		public int TopicReplyCount;

		[DataMember]
		public int RatingCount;

		[DataMember]
		public int Rating;

		[DataMember]
		public int? GroupOwnerId;

		[DataMember]
		public bool IsGroupPrivate;

		[DataMember]
		public bool ActualIsGroupPrivate;

		[DataMember]
		public int? ParentGroupId;

		[DataMember]
		public int Flags; //Convert to enum later

		[DataMember]
		public bool LockedForReplies;

		[DataMember]
		public int ParentAuthorId;

		[DataMember]
		public int TopicAuthorId;

		[DataMember]
		public ICollection<Tag> Tags;

		[DataMember]
		public bool IsTopicBanned;

		[DataMember]
		public int ActualParentPostId;

		[DataMember]
		public int Popularity;

		[DataMember]
		public bool IsActive;

		[DataMember]
		public bool IsAnnouncement;

		[DataMember]
		public int UserRating;

		[DataMember]
		public bool UserHasRated;

		[DataMember]
		public bool UserHasMutedPost;

		[DataMember]
		public int LatestReplyPostId;

		[DataMember]
		public int LatestReplyAuthorId;

		[DataMember]
		public IgnoreStatus IgnoreStatus;


		public Post(JObject j) {

			PostId = j["postId"].Value<int>();
			ThreadDepth = j["threadDepth"].Value<int>();
			Category = j["category"].Value<int>();
			AuthorMembershipId = j["authorMembershipId"].Value<int>();

			EditorMembershipId = j["editorMembershipId"] != null
				? j["editorMembershipId"].Value<int>()
				: (int?)null;

			RawSubject = j["subject"] != null
				? j["subject"].Value<string>()
				: null;

			Body = j["body"] != null
				? j["body"].Value<string>()
				: null;

			UrlLinkOrImage = j["urlLinkOrImage"].Value<string>();
			CreationDate = j["creationDate"].Value<DateTime>().ToUniversalTime();

			EditCount = j["editCount"].Value<int>();

			//Don't leave the DateTimes the same - it's silly
			if(EditCount > 0) {
				LastModified = j["lastModified"].Value<DateTime>().ToUniversalTime();
			}
			else{
				LastModified = null;
			}

			LastReplyDate = j["lastReplyDate"] != null
				? j["lastReplyDate"].Value<DateTime>().ToUniversalTime()
				: (DateTime?)null;

			ReplyCount = j["replyCount"].Value<int>();
			TopicReplyCount = j["topicReplyCount"].Value<int>();
			RatingCount = j["ratingCount"].Value<int>();
			Rating = j["rating"].Value<int>();

			GroupOwnerId = j["groupOwnerId"] != null
				? j["groupOwnerId"].Value<int>()
				: (int?)null;

			IsGroupPrivate = j["isGroupPrivate"].Value<bool>();
			ActualIsGroupPrivate = j["actualIsGroupPrivate"].Value<bool>();

			ParentGroupId = j["parentGroupId"] != null
				? j["parentGroupId"].Value<int>()
				: (int?)null;

			Flags = j["flags"].Value<int>();
			LockedForReplies = j["lockedForReplies"].Value<bool>();
			ParentAuthorId = j["parentAuthorId"].Value<int>();
			TopicAuthorId = j["topicAuthorId"].Value<int>();

			Tags = new List<Tag>();
			if(j["tags"] != null) {
				foreach(string t in j["tags"]) {
					Tags.Add(new Tag(t));
				}
			}

			IsTopicBanned = j["isTopicBanned"].Value<bool>();
			Popularity = j["popularity"].Value<int>();
			IsActive = j["isActive"].Value<bool>();
			IsAnnouncement = j["isAnnouncement"].Value<bool>();
			UserRating = j["userRating"].Value<int>();
			UserHasRated = j["userHasRated"].Value<bool>();
			UserHasMutedPost = j["userHasMutedPost"].Value<bool>();
			LatestReplyPostId = j["latestReplyPostId"].Value<int>();
			LatestReplyAuthorId = j["latestReplyAuthorId"].Value<int>();
			IgnoreStatus = new IgnoreStatus(j["ignoreStatus"].Value<JObject>());

		}

	}
}
