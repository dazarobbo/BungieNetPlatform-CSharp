using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Responses {

	[DataContract]
	public class GroupResponse : Response {

		[DataMember]
		public Group Group;


		public GroupResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				Group = new Group(j["Response"].Value<JObject>());
			}

		}

	}
}
