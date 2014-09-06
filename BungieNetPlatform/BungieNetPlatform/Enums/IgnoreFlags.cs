using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[Flags]
	[DataContract]
	public enum IgnoreFlags {

		[EnumMember]
		NotIgnored = 0,

		[EnumMember]
		IgnoredUser = 1,

		[EnumMember]
		IgnoredGroup = 2,

		[EnumMember]
		IgnoredByGroup = 4,

		[EnumMember]
		IgnoredPost = 8,

		[EnumMember]
		IgnoredTag = 16,

		[EnumMember]
		IgnoredGlobal = 32

	}
}
