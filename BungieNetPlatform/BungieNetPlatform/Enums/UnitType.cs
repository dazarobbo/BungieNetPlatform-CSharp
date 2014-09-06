using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum UnitType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Count = 1,

		[EnumMember]
		PerGame = 2,

		[EnumMember]
		Seconds = 3,

		[EnumMember]
		Points = 4,

		[EnumMember]
		Team = 5,

		[EnumMember]
		Distance = 6,

		[EnumMember]
		Percent = 7,

		[EnumMember]
		Ratio = 8,

		[EnumMember]
		Boolean = 9,

		[EnumMember]
		WeaponType = 10

	}

}