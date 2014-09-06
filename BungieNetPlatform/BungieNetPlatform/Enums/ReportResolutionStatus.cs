using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ReportResolutionStatus {

		[EnumMember]
		Unresolved = 0,

		[EnumMember]
		Innocent = 1,

		[EnumMember]
		GuiltyBan = 2,

		[EnumMember]
		GuiltyBlastBan = 3,

		[EnumMember]
		GuiltyWarn = 4,

		[EnumMember]
		GuiltyAlias = 5,

		[EnumMember]
		ResolveNoAction = 6

	}

}