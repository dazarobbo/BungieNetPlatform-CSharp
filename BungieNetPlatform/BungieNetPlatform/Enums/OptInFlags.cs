using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	[Flags]
	public enum OptInFlags {

		[EnumMember]
		Newsletter = 1,

		[EnumMember]
		System = 2,

		[EnumMember]
		Marketing = 4,

		[EnumMember]
		UserResearch = 8,

		[EnumMember]
		CustomerService = 16

	}

}