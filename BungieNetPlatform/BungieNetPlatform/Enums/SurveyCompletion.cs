using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum SurveyCompletion {

		[EnumMember]
		None = 0,

		[EnumMember]
		UserResearchWebPageOne = 1,

		[EnumMember]
		UserResearchWebPageTwo = 2

	}

}