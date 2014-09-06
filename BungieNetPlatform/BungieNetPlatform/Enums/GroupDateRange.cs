using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum GroupDateRange {

		[EnumMember]
		All = 0,

		[EnumMember]
		PastDay = 1,

		[EnumMember]
		PastWeek = 2,

		[EnumMember]
		PastMonth = 3,

		[EnumMember]
		PastYear = 4

	}

}