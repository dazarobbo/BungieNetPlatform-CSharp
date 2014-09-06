using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {
	[DataContract]
	public enum ChatSecurity {

		[EnumMember]
		AllMembers = 0,

		[EnumMember]
		AdminsOnly = 1

	}
}
