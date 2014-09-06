using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum GroupTypeSearchFilter {

		[EnumMember]
		None = 0,

		[EnumMember]
		BNextForumNinja = 1,

	}

}