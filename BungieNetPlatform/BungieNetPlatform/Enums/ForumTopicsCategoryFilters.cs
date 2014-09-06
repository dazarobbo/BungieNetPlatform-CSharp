using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[Flags]
	[DataContract]
	public enum ForumTopicsCategoryFilters {

		[EnumMember]
		None = 0,

		[EnumMember]
		Link = 1,

		[EnumMember]
		Question = 2,

		[EnumMember]
		AnsweredQuestion = 4,

		[EnumMember]
		Media = 8,

		[EnumMember]
		TextOnly = 16,

		[EnumMember]
		Announcement = 32,

		[EnumMember]
		BungieOfficial = 64,

		[EnumMember]
		Poll = 128

	}
}
