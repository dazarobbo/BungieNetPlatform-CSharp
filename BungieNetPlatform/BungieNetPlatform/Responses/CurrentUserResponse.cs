using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class CurrentUserResponse : Response {

		[DataMember]
		public CurrentUser User;


		public CurrentUserResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				User = new CurrentUser(j["Response"].Value<JObject>());
			}

		}

	}
}
