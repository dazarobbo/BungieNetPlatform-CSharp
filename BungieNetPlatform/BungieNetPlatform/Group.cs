using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Extensions;

namespace BungieNetPlatform {

	[DataContract]
	public class Group {

		[DataMember]
		public GroupDetail Detail;

		[DataMember]
		public int FounderMembershipId;

		[DataMember]
		public User Founder;

		[DataMember]
		public int FollowerCount;

		[DataMember]
		public GroupMembershipStatus CurrentUserStatus;

		[DataMember]
		public ICollection<int> AlliedIds;

		[DataMember]
		public ICollection<Attribute> Attributes;

		[DataMember]
		public ICollection<int> MembershipIds;

		//clanMemershipTypes
		//allianceStatus
		//friends

		[DataMember]
		public int GroupJoinRequestCount;

		[DataMember]
		public int GroupJoinInviteCount;

		[DataMember]
		public int ClanJoinRequestCount;

		[DataMember]
		public int ClanJoinInviteCount;


		public Group(JObject j) {

			Detail = new GroupDetail(j["detail"].Value<JObject>());
			FounderMembershipId = j["founderMembershipId"].Value<int>();
			Founder = new User(j["founder"].Value<JObject>());
			FollowerCount = j["followerCount"].Value<int>();


			CurrentUserStatus = new GroupMembershipStatus(
				j["currentUserStatus"]["membershipStatus"]["Response"].Value<JObject>()
			);

			AlliedIds = new List<int>();
			j["alliedIds"].ForEach(i => AlliedIds.Add(i.Value<int>()));

			Attributes = new List<Attribute>();
			j["attributes"].ForEach(a => Attributes.Add(new Attribute(
				a["attributeId"].Value<int>(),
				a["minValue"].Value<int>(),
				a["maxValue"].Value<int>()
			)));

			MembershipIds = new List<int>();
			j["membershipIds"].ForEach(i => MembershipIds.Add(i.Value<int>()));

			GroupJoinRequestCount = j["groupJoinRequestCount"].Value<int>();
			GroupJoinInviteCount = j["groupJoinInviteCount"].Value<int>();
			ClanJoinRequestCount = j["clanJoinRequestCount"].Value<int>();
			ClanJoinInviteCount = j["clanJoinInviteCount"].Value<int>();

		}

		public override string ToString() {
			return Detail.Name;
		}

	}
}
