using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum FriendOnlineStatus {

		[EnumMember]
		Offline = 0,

		[EnumMember]
		Online = 1,

		[EnumMember]
		Idle = 2

	}

}