using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class UserResponse : Response {

		[DataMember]
		public User User;


		public UserResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				User = new User(j["Response"].Value<JObject>());
			}

		}

	}
}
