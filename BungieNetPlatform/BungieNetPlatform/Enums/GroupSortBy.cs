using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum GroupSortBy {

		[EnumMember]
		Name = 0,

		[EnumMember]
		Date = 1,

		[EnumMember]
		Popularity = 2,

		[EnumMember]
		Id = 3

	}

}