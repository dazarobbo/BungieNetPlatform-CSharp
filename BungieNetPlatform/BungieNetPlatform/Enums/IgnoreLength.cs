using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum IgnoreLength {

		[EnumMember]
		None = 0,

		[EnumMember]
		Week = 1,

		[EnumMember]
		TwoWeeks = 2,

		[EnumMember]
		ThreeWeeks = 3,

		[EnumMember]
		Month = 4,

		[EnumMember]
		ThreeMonths = 5,

		[EnumMember]
		SixMonths = 6,

		[EnumMember]
		Year = 7,

		[EnumMember]
		Forever = 8,

		[EnumMember]
		ThreeMinutes = 9,

		[EnumMember]
		Hour = 10

	}

}