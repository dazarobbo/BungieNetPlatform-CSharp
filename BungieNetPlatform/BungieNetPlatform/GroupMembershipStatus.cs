using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetPlatform {

	[DataContract]
	public class GroupMembershipStatus {

		[DataMember]
		public User User;

		/// <summary>
		/// Unknown
		/// </summary>
		[DataMember]
		public ICollection<int> ClanMembershipTypes;

		[DataMember]
		public int GroupId;

		[DataMember]
		public int MembershipId;

		[DataMember]
		public bool HasPendingApplication;

		[DataMember]
		public bool IsMember;

		[DataMember]
		public bool HasRated;

		[DataMember]
		public DateTime? ApprovalDate;

		[DataMember]
		public int? ApprovedByMembershipId;

		[DataMember]
		public DateTime? DeactivationDate;

		[DataMember]
		public int? DeactivatedByMembershipId;

		[DataMember]
		public int? Rating;

		[DataMember]
		public int MemberType;

		[DataMember]
		public bool IsOriginalFounder;

		public GroupMembershipStatus(JObject r) {

			GroupId = r["groupId"].Value<int>();
			MembershipId = r["membershipId"].Value<int>();
			HasPendingApplication = r["hasPendingApplication"].Value<bool>();
			IsMember = r["isMember"].Value<bool>();
			HasRated = r["hasRated"].Value<bool>();

			if(r["approvalDate"] != null) {
				ApprovalDate = r["approvalDate"].Value<DateTime>().ToUniversalTime();

				//Check for 0001-01-01T00:00:00Z year
				if(ApprovalDate.Value.Year == 1) {
					ApprovalDate = null;
				}

				ApprovedByMembershipId = r["approvedByMembershipId"].Value<int>();
				if(ApprovedByMembershipId == 0) {
					ApprovedByMembershipId = null;
				}

			}

			if(r["deactivationDate"] != null) {
				
				DeactivationDate = r["deactivationDate"].Value<DateTime>().ToUniversalTime();
				if(DeactivationDate.Value.Year == 1) {
					DeactivationDate = null;
				}

				DeactivatedByMembershipId = r["deactivatedByMembershipId"].Value<int>();
				if(DeactivatedByMembershipId == 0) {
					DeactivatedByMembershipId = null;
				}

			}

			Rating = HasRated ? r["rating"].Value<int>() : (int?)null;
			MemberType = r["memberType"].Value<int>();
			IsOriginalFounder = r["isOriginalFounder"].Value<bool>();

		}

	}
}
