using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum DestinyDefinitionType {

		[EnumMember]
		None = 0,

		[EnumMember]
		Activity = 1,

		[EnumMember]
		ActivityType = 2,

		[EnumMember]
		Class = 3,

		[EnumMember]
		Gender = 4,

		[EnumMember]
		InventoryBucket = 5,

		[EnumMember]
		InventoryItem = 6,

		[EnumMember]
		Progression = 7,

		[EnumMember]
		Race = 8,

		[EnumMember]
		Stat = 9,

		[EnumMember]
		TalentGrid = 10,

		[EnumMember]
		StatGroup = 11,

		[EnumMember]
		UnlockFlag = 12,

		[EnumMember]
		Vendor = 13,

		[EnumMember]
		Destination = 14,

		[EnumMember]
		Place = 15,

		[EnumMember]
		DirectorBook = 16,

		[EnumMember]
		MaterialRequirement = 17,

		[EnumMember]
		SandboxPerk = 18,

		[EnumMember]
		ArtDye = 19,

		[EnumMember]
		ArtDyeChannel = 20,

		[EnumMember]
		ActivityBundle = 21,

		[EnumMember]
		GearAsset = 22

	}

}