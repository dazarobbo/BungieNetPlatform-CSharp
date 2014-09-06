using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ForumPostPopularity {

		[EnumMember]
		Empty = 0,

		[EnumMember]
		Default = 1,

		[EnumMember]
		Discussed = 2,

		[EnumMember]
		CoolStory = 3,

		[EnumMember]
		HeatingUp = 4,

		[EnumMember]
		Hot = 5

	}

}