using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum DestinyStatsGroupType {

		[EnumMember]
		None = 0,

		[EnumMember]
		General = 1,

		[EnumMember]
		Weapons = 2,

		[EnumMember]
		Medals = 3,

		[EnumMember]
		Enemies = 4,

		[EnumMember]
		ReservedGroups = 100,

		[EnumMember]
		Leaderboard = 101,

		[EnumMember]
		Activity = 102,

		[EnumMember]
		UniqueWeapon = 103

	}

}