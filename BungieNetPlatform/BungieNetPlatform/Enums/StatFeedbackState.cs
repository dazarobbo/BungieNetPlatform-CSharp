using System.Runtime.Serialization;
using System;

namespace BungieNetPlatform.Enums {

	[DataContract]
	[Flags]
	public enum StatFeedbackState {

		[EnumMember]
		Good = 0,

		[EnumMember]
		TooHigh = 1,

		[EnumMember]
		TooLow = 2,

		[EnumMember]
		WrongName = 4

	}

}