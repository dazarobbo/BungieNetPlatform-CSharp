using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class CreatePostResponse : Response {
		
		[DataMember]
		public Post Post;


		public CreatePostResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				Post = new Post(j["Response"].Value<JObject>());
			}

		}

	}
}
