using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum TextParameterSearchType {

		[EnumMember]
		Contains = 0,

		[EnumMember]
		Exact = 1,

		[EnumMember]
		StartsWith = 2,

		[EnumMember]
		EndsWith = 3

	}

}