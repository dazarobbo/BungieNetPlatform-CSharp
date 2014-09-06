using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ItemBindStatus {

		[EnumMember]
		NotBound = 0,

		[EnumMember]
		BoundToCharacter = 1,

		[EnumMember]
		BoundToAccount = 2,

		[EnumMember]
		BoundToBuild = 3

	}

}