using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum AffectedItemType {

		[EnumMember]
		None = -1,

		[EnumMember]
		User = 0,

		[EnumMember]
		Post = 1,

		[EnumMember]
		Topic = 2,

		[EnumMember]
		Group = 3,

		[EnumMember]
		Tag = 4

	}

}