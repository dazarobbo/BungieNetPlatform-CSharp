using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum ClientDeviceType {

		[EnumMember]
		Unknown = 0,

		[EnumMember]
		Xbox360 = 1,

		[EnumMember]
		Playstation3 = 2,

		[EnumMember]
		AndroidPhone = 3,

		[EnumMember]
		AndroidTablet = 4,

		[EnumMember]
		ApplePhone = 5,

		[EnumMember]
		AppleTablet = 6,

		[EnumMember]
		WebBrowser = 7,

		[EnumMember]
		NativeWindows = 8,

		[EnumMember]
		NativeMac = 9,

		[EnumMember]
		WindowsPhone = 10,

		[EnumMember]
		WindowsTablet = 11,

		[EnumMember]
		XboxOne = 12,

		[EnumMember]
		Playstation4 = 13,

		[EnumMember]
		Fake = 255,

	}

}