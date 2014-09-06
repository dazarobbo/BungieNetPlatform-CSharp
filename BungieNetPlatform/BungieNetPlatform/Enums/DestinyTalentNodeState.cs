using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum DestinyTalentNodeState {

		[EnumMember]
		Invalid = 0,

		[EnumMember]
		CanUpgrade = 1,

		[EnumMember]
		NoPoints = 2,

		[EnumMember]
		NoPrerequisites = 3,

		[EnumMember]
		NoSteps = 4,

		[EnumMember]
		NoUnlock = 5,

		[EnumMember]
		NoMaterial = 6,

		[EnumMember]
		NoGridLevel = 7,

		[EnumMember]
		SwappingLocked = 8,

		[EnumMember]
		MustSwap = 9,

		[EnumMember]
		Complete = 10,

		[EnumMember]
		Unknown = 11

	}

}