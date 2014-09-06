using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace BungieNetPlatform {

	[DataContract]
	public class MessageDetail {

		[DataMember]
		public string Body;

		[DataMember]
		public int ConversationId;

		[DataMember]
		public DateTime DateStarted;

		[DataMember]
		public int InvitationId;

		[DataMember]
		public bool IsAutoResponse;

		[DataMember]
		public bool IsGlobal;

		[DataMember]
		public bool IsLocked;

		[DataMember]
		public bool IsRead;

		[DataMember]
		public int LastMessageId;

		[DataMember]
		public DateTime LastMessageSent;

		[DataMember]
		public DateTime LastRead;

		[DataMember]
		public int MemberFromId;

		[DataMember]
		public int OwnerEntityId;

		[DataMember]
		public int OwnerEntityType;

		[DataMember]
		public int Starter;

		[DataMember]
		public int Status;

		[DataMember]
		public string Subject;

		[DataMember]
		public int TotalMessageCount;


		public MessageDetail(JObject j) {

			Body = j["body"].Value<string>();
			ConversationId = j["conversationId"].Value<int>();
			DateStarted = j["dateStarted"].Value<DateTime>().ToUniversalTime();
			InvitationId = j["invitationId"].Value<int>();
			IsAutoResponse = j["isAutoResponse"].Value<bool>();
			IsGlobal = j["isGlobal"].Value<bool>();
			IsLocked = j["isLocked"].Value<bool>();
			IsRead = j["isRead"].Value<bool>();
			LastMessageId = j["lastMessageId"].Value<int>();
			LastMessageSent = j["lastMessageSent"].Value<DateTime>().ToUniversalTime();
			LastRead = j["lastRead"].Value<DateTime>().ToUniversalTime();
			MemberFromId = j["memberFromId"].Value<int>();
			OwnerEntityId = j["ownerEntityId"].Value<int>();
			OwnerEntityType = j["ownerEntityType"].Value<int>();
			Starter = j["starter"].Value<int>();
			Status = j["status"].Value<int>();
			Subject = j["subject"].Value<string>();
			TotalMessageCount = j["totalMessageCount"].Value<int>();

		}

	}
}
