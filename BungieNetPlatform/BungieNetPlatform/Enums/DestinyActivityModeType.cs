using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum DestinyActivityModeType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Story = 1,

		[EnumMember]
		Strike = 2,

		[EnumMember]
		Raid = 4,

		[EnumMember]
		AllPvP = 5,

		[EnumMember]
		Explore = 6,

		[EnumMember]
		AllPvE = 7,

		[EnumMember]
		PvPIntroduction = 8,

		[EnumMember]
		ThreeVsThree = 9,

		[EnumMember]
		Control = 10,

		[EnumMember]
		Lockdown = 11,

		[EnumMember]
		Team = 12,

		[EnumMember]
		FreeForAll = 13

	}

}