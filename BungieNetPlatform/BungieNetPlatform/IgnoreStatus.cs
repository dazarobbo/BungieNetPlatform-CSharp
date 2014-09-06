using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using BungieNetPlatform.Enums;

namespace BungieNetPlatform {

	[DataContract]
	public class IgnoreStatus {

		[DataMember]
		public bool Ignored;

		[DataMember]
		public IgnoreFlags Flags;

		public IgnoreStatus(JObject j) {
			Ignored = j["isIgnored"].Value<bool>();
			Flags = (IgnoreFlags)j["ignoreFlags"].Value<int>();
		}

	}
}
