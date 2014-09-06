using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Extensions;

namespace BungieNetPlatform {

	[DataContract]
	public class Message {

		[DataMember]
		public MessageDetail Detail;

		[DataMember]
		public ICollection<MessageParticipant> Participants;

		public Message(JObject j) {

			Participants = new List<MessageParticipant>();

			Detail = new MessageDetail(j["detail"].Value<JObject>());

			j["participants"].Cast<JObject>()
				.ForEach(p => Participants.Add(new MessageParticipant(p)));

		}

	}
}
