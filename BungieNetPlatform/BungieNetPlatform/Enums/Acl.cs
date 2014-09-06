using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums{

	[DataContract]
	public enum Acl {

		[EnumMember]
		None = 0,

		[EnumMember]
		BNextForumNinja = 1,

		[EnumMember]
		BNextUnlimitedGroups = 2,

		[EnumMember]
		BNextFounderInAllGroups = 3,

		[EnumMember]
		BNextBungieGold = 4,

		[EnumMember]
		BNextNinjaColors = 5,

		[EnumMember]
		BNextMakeOfficialTopics = 6,

		[EnumMember]
		BNextMakeNinjaTopics = 7,

		[EnumMember]
		BNextDeleteForumTopics = 8,

		[EnumMember]
		BNextOverturnReports = 9,

		[EnumMember]
		BNextBrowseReports = 10,

		[EnumMember]
		BNextGlobalIgnore = 11,

		[EnumMember]
		BNextEditAnyPublicPost = 12,

		[EnumMember]
		BNextEditUsers = 13,

		[EnumMember]
		BNextUltraBan = 14,

		[EnumMember]
		BNextForumMentor = 15

	}
}
