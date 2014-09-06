using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum RequestedPunishment {

		[EnumMember]
		Ban = 0,

		[EnumMember]
		Warn = 1,

		[EnumMember]
		BlastBan = 2

	}

}