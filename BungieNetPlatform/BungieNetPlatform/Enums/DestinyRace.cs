using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum DestinyRace {

		[EnumMember]
		Human = 0,

		[EnumMember]
		Awoken = 1,

		[EnumMember]
		Exo = 2,

		[EnumMember]
		Unknown = 3

	}

}