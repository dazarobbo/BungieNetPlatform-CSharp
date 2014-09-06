using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {
	[Flags]
	[DataContract]
	public enum ForumPostCategory {

		[EnumMember]
		None = 0,

		[EnumMember]
		TextOnly = 1,

		[EnumMember]
		Media = 2,

		[EnumMember]
		Link = 4,

		[EnumMember]
		Poll = 8,

		[EnumMember]
		Question = 16,

		[EnumMember]
		Answered = 32,

		[EnumMember]
		Announcement = 64,

		[EnumMember]
		ContentComment = 128,

		[EnumMember]
		BungieOfficial = 256,

		[EnumMember]
		NinjaOfficial = 512

	}
}
