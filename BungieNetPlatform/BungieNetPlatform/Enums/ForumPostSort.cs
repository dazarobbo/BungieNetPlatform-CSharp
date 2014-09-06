using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ForumPostSort {

		[EnumMember]
		Default = 0,

		[EnumMember]
		OldestFirst = 1

	}

}