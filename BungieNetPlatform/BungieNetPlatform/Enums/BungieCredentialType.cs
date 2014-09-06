using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum BungieCredentialType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Xuid = 1,

		[EnumMember]
		Psnid = 2,

		[EnumMember]
		Wlid = 3,

		[EnumMember]
		Fake = 4,

		[EnumMember]
		Facebook = 5,

		[EnumMember]
		Google = 8,

		[EnumMember]
		Windows = 9,

		[EnumMember]
		DemonId = 10

	}

}