using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using Extensions;

namespace BungieNetPlatform.Responses {
	[DataContract]
	public class GetMessagesResponse : QueryableResponse {

		public ICollection<Group> Groups;
		public ICollection<string> InvitationDetails;
		public int UnreadCount;
		public ICollection<User> Users;
		public ICollection<Message> Messages;

		public GetMessagesResponse(JObject j) : base(j) {

			Groups = new List<Group>();
			Messages = new List<Message>();
			Users = new List<User>();
			InvitationDetails = new List<string>();

			if(j["Response"] != null) {

				j["Response"]["groups"]
					.Cast<JObject>()
					.ForEach(g => Groups.Add(new Group(g)));

				//Unsure of how/what invitationDetails is

				j["Response"]["results"]
					.Cast<JObject>()
					.ForEach(m => Messages.Add(new Message(m)));

				j["Response"]["users"]
					.Cast<JObject>()
					.ForEach(u => Users.Add(new User(u)));

				UnreadCount = j["Response"]["unreadCount"].Value<int>();

			}


		}

	}
}
