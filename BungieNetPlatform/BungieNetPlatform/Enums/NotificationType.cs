using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum NotificationType {

		[EnumMember]
		Message = 1,

		[EnumMember]
		ForumReply = 2,

		[EnumMember]
		NewActivityRollup = 3,

		[EnumMember]
		SettingsChange = 4,

		[EnumMember]
		GroupAcceptance = 5,

		[EnumMember]
		GroupJoinRequest = 6,

		[EnumMember]
		FollowUserActivity = 7,

		[EnumMember]
		FriendUserActivity = 8,

		[EnumMember]
		ForumLike = 9,

		[EnumMember]
		Followed = 10,

		[EnumMember]
		GroupBanned = 11,

		[EnumMember]
		Banned = 12,

		[EnumMember]
		Unbanned = 13,

		[EnumMember]
		GroupOpenJoin = 14,

		[EnumMember]
		GroupAllianceJoinRequested = 15,

		[EnumMember]
		GroupAllianceJoinRejected = 16,

		[EnumMember]
		GroupAllianceJoinApproved = 17,

		[EnumMember]
		GroupAllianceBroken = 18,

		[EnumMember]
		GroupDenial = 19,

		[EnumMember]
		Warned = 20,

		[EnumMember]
		ClanDisabled = 21,

		[EnumMember]
		GroupAllianceInviteRequested = 22,

		[EnumMember]
		GroupAllianceInviteRejected = 23,

		[EnumMember]
		GroupAllianceInviteApproved = 24,

		[EnumMember]
		GroupFollowedByGroup = 25,

		[EnumMember]
		GrimoireUnobservedCards = 26

	}
}
