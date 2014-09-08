using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BungieNetPlatform.Responses {
	public class GetUserResponse : Response {

		public User User;

		public GetUserResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				User = new User(j["Response"].Value<JObject>());
			}

		}


	}
}
