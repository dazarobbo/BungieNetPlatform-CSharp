using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum IgnoredItemType {

		[EnumMember]
		All = 0,

		[EnumMember]
		Post = 1,

		[EnumMember]
		Group = 2,

		[EnumMember]
		User = 3,

		[EnumMember]
		Tag = 4

	}

}