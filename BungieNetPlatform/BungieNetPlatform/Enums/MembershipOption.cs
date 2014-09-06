using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum MembershipOption {

		[EnumMember]
		Reviewed = 0,

		[EnumMember]
		Open = 1,

		[EnumMember]
		Closed = 2

	}

}