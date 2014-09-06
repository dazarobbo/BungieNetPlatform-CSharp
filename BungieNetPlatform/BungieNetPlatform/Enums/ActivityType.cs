using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ActivityType {

		[EnumMember]
		None = -1,

		[EnumMember]
		Create = 0,

		[EnumMember]
		Edit = 1,

		[EnumMember]
		Delete = 2,

		[EnumMember]
		Rate = 3,

		[EnumMember]
		Follow = 4,

		[EnumMember]
		Unfollow = 5,

		[EnumMember]
		Apply = 6,

		[EnumMember]
		Rescind = 7,

		[EnumMember]
		Approve = 8,

		[EnumMember]
		Deny = 9,

		[EnumMember]
		Kick = 10,

		[EnumMember]
		EditMembershipType = 11,

		[EnumMember]
		Like = 12,

		[EnumMember]
		Unlike = 13,

		[EnumMember]
		Share = 14,

		[EnumMember]
		TaggedGroup = 15,

		[EnumMember]
		TaggedTopic = 16,

		[EnumMember]
		AvatarChanged = 17,

		[EnumMember]
		DisplayNameChanged = 18,

		[EnumMember]
		TitleChanged = 19,

		[EnumMember]
		TitleUnlocked = 20,

		[EnumMember]
		GroupTopicCreate = 21,

		[EnumMember]
		GroupReplyCreate = 22,

		[EnumMember]
		Reply = 23,

		[EnumMember]
		ChangeClanName = 24,

		[EnumMember]
		GroupAllianceRejected = 26,

		[EnumMember]
		GroupAllianceApproved = 27,

		[EnumMember]
		GroupAllianceBroken = 28

	}

}