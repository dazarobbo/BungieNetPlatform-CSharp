using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ActivityStatus {

		[EnumMember]
		Processing = 0,

		[EnumMember]
		Failed = 1,

		[EnumMember]
		Skipped = 2,

		[EnumMember]
		Complete = 3

	}

}