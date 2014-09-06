using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace BungieNetPlatform {

	[DataContract]
	public class Context {

		[DataMember]
		public bool Following;

		[DataMember]
		public IgnoreStatus IgnoreStatus;


		public Context(JObject j) {
			Following = j["isFollowing"].Value<bool>();
			IgnoreStatus = new IgnoreStatus(j["ignoreStatus"].Value<JObject>());
		}

	}
}
