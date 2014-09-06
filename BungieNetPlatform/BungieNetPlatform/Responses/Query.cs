using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class Query {

		[DataMember]
		public int CurrentPage;

		[DataMember]
		public int ItemsPerPage;


		public Query(JObject j) {

			CurrentPage = j["currentPage"].Value<int>();
			ItemsPerPage = j["itemsPerPage"].Value<int>();

		}

	}
}
