using System;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Enums {

	[DataContract]
	public enum VendorItemStatus {

		[EnumMember]
		Success = 0,

		[EnumMember]
		NoInventorySpace = 1,

		[EnumMember]
		NoFunds = 2,

		[EnumMember]
		NoProgression = 3,

		[EnumMember]
		NoUnlock = 4,

		[EnumMember]
		NoQuantity = 5,

		[EnumMember]
		OutsidePurchaseWindow = 6,

		[EnumMember]
		NotAvailable = 7,

		[EnumMember]
		UniquenessViolation = 8,

		[EnumMember]
		UnknownError = 9

	}

}