using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ActivityQueryFilter {

		[EnumMember]
		All = 0,

		[EnumMember]
		Friends = 1,

		[EnumMember]
		Following = 2,

		[EnumMember]
		Groups = 3,

		[EnumMember]
		Mine = 4,

		[EnumMember]
		Tags = 5,

		[EnumMember]
		Clans = 6

	}

}