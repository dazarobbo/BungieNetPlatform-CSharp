using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using BungieNetPlatform.Enums;

namespace BungieNetPlatform.Notifications {

	[DataContract]
	public class Notification {

		[DataMember]
		public bool NotifySelf;

		[DataMember]
		public DateTime CreationDate;

		[DataMember]
		public bool IsNew;

		[DataMember]
		public User MemberInitiated;

		[DataMember]
		public int MemberInitiatedId;

		[DataMember]
		public int MembershipId;

		[DataMember]
		public string NotificationDetail;

		[DataMember]
		public int NotificationId;

		[DataMember]
		public NotificationType NotificationType;

		[DataMember]
		public int RelatedChildItemId;

		[DataMember]
		public string RelatedItemDetail;

		[DataMember]
		public int RelatedItemId;


		public Notification(JObject j) {

			NotifySelf = j["NotifySelf"].Value<bool>();
			CreationDate = j["createdDate"].Value<DateTime>().ToUniversalTime();
			IsNew = j["isNew"].Value<bool>();

			MemberInitiated = j["memberInitiated"] != null
				? new User(j["memberInitiated"].Value<JObject>())
				: null;

			MemberInitiatedId = j["memberInitiatedId"].Value<int>();
			MembershipId = j["membershipId"].Value<int>();
			NotificationDetail = j["notificationDetail"].Value<string>();
			NotificationType = (NotificationType)j["notificationType"].Value<int>();
			RelatedChildItemId = j["relatedChildItemId"].Value<int>();
			RelatedItemDetail = j["relatedItemDetail"].Value<string>();
			RelatedItemId = j["relatedItemId"].Value<int>();

		}


		//Casts
		public static explicit operator MessageNotification(Notification n){
			return new MessageNotification() {
				Sender = n.MemberInitiated
			};
		}

		public static explicit operator ForumReplyNotification(Notification n) {

			ForumReplyNotification f = new ForumReplyNotification();

			f.Replier = n.MemberInitiated;
			f.PostId = n.RelatedItemId;

			Match m = Regex.Match(
				n.RelatedItemDetail,
				@"(\d+) repl(?:y|ies)",
				RegexOptions.Singleline | RegexOptions.IgnoreCase
				);

			f.ReplyCount = int.Parse(m.Groups[1].Value);

			return f;

		}




	}
}