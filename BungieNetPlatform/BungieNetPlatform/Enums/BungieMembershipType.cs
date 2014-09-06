using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum BungieMembershipType {

		[EnumMember]
		None = 0,

		[EnumMember]
		TigerXbox = 1,

		[EnumMember]
		TigerPsn = 2,

		[EnumMember]
		TigerDemon = 10,

		[EnumMember]
		BungieNext = 254,

		[EnumMember]
		All = -1

	}

}