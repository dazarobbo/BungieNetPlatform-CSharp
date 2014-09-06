using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ContentSortby {

		[EnumMember]
		CreationDate = 0,

		[EnumMember]
		CmsPath = 1

	}

}