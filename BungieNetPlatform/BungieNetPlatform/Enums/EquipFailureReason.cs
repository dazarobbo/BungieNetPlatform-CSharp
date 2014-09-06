using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[Flags]
	[DataContract]
	public enum EquipFailureReason {

		[EnumMember]
		None = 0,

		[EnumMember]
		ItemUnequippable = 1,

		[EnumMember]
		ItemUniqueEquipRestricted = 2,

		[EnumMember]
		ItemFailedUnlockCheck = 4,

		[EnumMember]
		ItemFailedLevelCheck = 8,

		[EnumMember]
		ItemNotOnCharacter = 16

	}

}