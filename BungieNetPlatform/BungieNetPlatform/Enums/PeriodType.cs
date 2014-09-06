using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum PeriodType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Daily = 1,

		[EnumMember]
		Monthly = 2,

		[EnumMember]
		AllTime = 3,

		[EnumMember]
		Activity = 4

	}

}