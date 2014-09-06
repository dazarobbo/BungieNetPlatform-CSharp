using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace BungieNetPlatform {
	[DataContract]
	public class MessageParticipant {

		[DataMember]
		public int MembershipId;

		[DataMember]
		public bool Deleted;


		public MessageParticipant(int membershipId, bool deleted) {
			MembershipId = membershipId;
			Deleted = deleted;
		}

		public MessageParticipant(JObject j) {
			MembershipId = j["membershipId"].Value<int>();
			Deleted = j["isDeleted"].Value<bool>();
		}

	}
}
