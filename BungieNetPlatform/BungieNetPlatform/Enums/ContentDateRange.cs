using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ContentDateRange {

		[EnumMember]
		All = 0,

		[EnumMember]
		Today = 1,

		[EnumMember]
		Yesterday = 2,

		[EnumMember]
		ThisMonth = 3,

		[EnumMember]
		ThisYear = 4,

		[EnumMember]
		LastYear = 5,

		[EnumMember]
		EarlierThanLastYear = 6

	}

}