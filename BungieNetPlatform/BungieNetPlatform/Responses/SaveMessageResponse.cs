using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class SaveMessageResponse : Response {

		[DataMember]
		public int Id;


		public SaveMessageResponse(JObject j) : base(j) {

			if(j["Response"] != null) {
				Id = j["Response"].Value<int>();
			}

		}

	}
}
