using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum TierType {

		[EnumMember]
		Unknown = 0,

		[EnumMember]
		Currency = 1,

		[EnumMember]
		Basic = 2,

		[EnumMember]
		Common = 3,

		[EnumMember]
		Rare = 4,

		[EnumMember]
		Superior = 5,

		[EnumMember]
		Exotic = 6

	}

}