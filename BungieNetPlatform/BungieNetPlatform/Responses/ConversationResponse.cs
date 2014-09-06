using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Extensions;
using BungieNetPlatform;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class ConversationResponse : QueryableResponse {

		[DataMember]
		public object InvitationDetails;

		[DataMember]
		public ICollection<Message> Messages;

		[DataMember]
		public ICollection<User> Users;


		public ConversationResponse(JObject j) : base(j) {

			Messages = new List<Message>();

			j["Response"]["results"].Cast<JObject>()
				.ForEach(m => Messages.Add(new Message(m)));

			Users = new List<User>();
			j["Response"]["users"].ForEach(uObj => {
				Users.Add(new User(uObj.First.Value<JObject>()));
			});
			
		}


	}
}
