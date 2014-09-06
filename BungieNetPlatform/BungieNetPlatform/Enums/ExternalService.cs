using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ExternalService {

		[EnumMember]
		None = 0,

		[EnumMember]
		Twitter = 1,

		[EnumMember]
		Facebook = 2,

		[EnumMember]
		Youtube = 3,

		[EnumMember]
		TwitterHelp = 4

	}

}