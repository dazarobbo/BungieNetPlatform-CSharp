using System.Runtime.Serialization;
using System;

namespace BungieNetPlatform.Enums {

	[DataContract]
	[Flags]
	public enum ForumFlags {

		[EnumMember]
		None = 0,

		[EnumMember]
		BungieStaffPost = 1,

		[EnumMember]
		ForumNinjaPost = 2,

		[EnumMember]
		ForumMentorPost = 4

	}

}