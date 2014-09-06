using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Globalization;
using Extensions;
using BungieNetPlatform.Enums;

namespace BungieNetPlatform {

	[DataContract]
	public class GroupDetail {

		[DataMember]
		public int Id;

		[DataMember]
		public string Name;

		[DataMember]
		public int MembershipIdCreated;

		[DataMember]
		public DateTime CreationDate;

		[DataMember]
		public int GroupType; //enum?

		[DataMember]
		public string About;

		[DataMember]
		public bool IsDeleted;

		[DataMember]
		public ICollection<Tag> Tags;

		[DataMember]
		public int Rating;

		[DataMember]
		public int RatingCount;

		[DataMember]
		public int MemberCount;

		[DataMember]
		public int PendingMemberCount;

		[DataMember]
		public bool IsPublic;

		[DataMember]
		public bool IsMembershipClosed;

		[DataMember]
		public bool IsMembershipReviewed;

		[DataMember]
		public bool IsPublicTopicAdminOnly;

		[DataMember]
		public int PrimaryAlliedGroupId;

		[DataMember]
		public string ClanCallsign;

		[DataMember]
		public bool AllowChat;

		[DataMember]
		public bool IsDefaultPostPublic;

		[DataMember]
		public bool IsDefaultPostAlliance;

		[DataMember]
		public ChatSecurity ChatSecurity;

		[DataMember]
		public CultureInfo Locale;

		[DataMember]
		public int AvatarImageIndex;

		[DataMember]
		public int FounderMembershipId;

		[DataMember]
		public GroupHomepage Homepage;

		[DataMember]
		public MembershipOption_Old MembershipOption;

		/// <summary>
		/// Unknown
		/// </summary>
		[DataMember]
		public int DefaultPublicity;

		[DataMember]
		public string Theme;

		[DataMember]
		public string BannerPath;

		[DataMember]
		public string AvatarPath;

		[DataMember]
		public bool IsAllianceOwner;

		[DataMember]
		public int ConversationId;


		/// <summary>
		/// TODO: assign other data members
		/// </summary>
		/// <param name="j"></param>
		public GroupDetail(JObject j) {

			Id = j["groupId"].Value<int>();
			Name = j["name"].Value<string>();
			MembershipIdCreated = j["membershipIdCreated"].Value<int>();
			CreationDate = j["creationDate"].Value<DateTime>().ToUniversalTime();
			GroupType = j["groupType"].Value<int>();
			About = j["about"].Value<string>();
			IsDeleted = j["isDeleted"].Value<bool>();
			Tags = new List<Tag>();
			j["tags"].ForEach(t => Tags.Add(new Tag(t.Value<string>())));
			Rating = j["rating"].Value<int>();
			RatingCount = j["ratingCount"].Value<int>();
			MemberCount = j["memberCount"].Value<int>();
			PendingMemberCount = j["pendingMemberCount"].Value<int>();
			IsPublic = j["isPublic"].Value<bool>();
			IsMembershipClosed = j["isMembershipClosed"].Value<bool>();
			IsMembershipReviewed = j["isMembershipReviewed"].Value<bool>();
			IsPublicTopicAdminOnly = j["isPublicTopicAdminOnly"].Value<bool>();
			IsDefaultPostPublic = j["isDefaultPostPublic"].Value<bool>();
			Theme = j["theme"].Value<string>();
			AvatarImageIndex = j["avatarImageIndex"].Value<int>();
			FounderMembershipId = j["founderMembershipId"].Value<int>();
			BannerPath = j["bannerPath"].Value<string>();
			AvatarPath = j["avatarPath"].Value<string>();

			ConversationId = j["conversationId"].Value<int>();

		}

	}
}
