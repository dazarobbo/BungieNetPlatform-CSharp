using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ForumTopicsSort {

		[EnumMember]
		Default = 0,

		[EnumMember]
		Latest = 1,

		[EnumMember]
		MostReplied = 2,

		[EnumMember]
		Popular = 3,

		[EnumMember]
		Controversial = 4,

		[EnumMember]
		Liked = 5,

		[EnumMember]
		HighestRated = 6

	}
}
