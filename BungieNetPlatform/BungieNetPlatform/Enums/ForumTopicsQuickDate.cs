using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ForumTopicsQuickDate {

		[EnumMember]
		All = 0,

		[EnumMember]
		LastYear = 1,

		[EnumMember]
		LastMonth = 2,

		[EnumMember]
		LastWeek = 3,

		[EnumMember]
		LastDay = 4

	}
}
