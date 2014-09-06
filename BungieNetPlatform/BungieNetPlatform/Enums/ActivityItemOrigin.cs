using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ActivityItemOrigin {

		[EnumMember]
		Undetermined = -1,

		[EnumMember]
		FollowedGroup = 0,

		[EnumMember]
		FollowedUser = 1,

		[EnumMember]
		ActivitiesAboutMe = 2,

		[EnumMember]
		MyActivities = 3

	}

}