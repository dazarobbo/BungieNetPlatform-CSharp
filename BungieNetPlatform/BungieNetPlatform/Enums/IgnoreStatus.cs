using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	[Flags]
	public enum IgnoreStatus {

		[EnumMember]
		NotIgnored = 0,

		[EnumMember]
		IgnoredUser = 1,

		[EnumMember]
		IgnoredGroup = 2,

		[EnumMember]
		IgnoredByGroup = 3,

		[EnumMember]
		IgnoredPost = 8,

		[EnumMember]
		IgnoredTag = 16,

		[EnumMember]
		IgnoredGlobal = 32

	}

}