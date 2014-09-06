using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum DamageType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Kinetic = 1,

		[EnumMember]
		Arc = 2,

		[EnumMember]
		Thermal = 3,

		[EnumMember]
		Void = 4,

		[EnumMember]
		Raid = 5

	}

}