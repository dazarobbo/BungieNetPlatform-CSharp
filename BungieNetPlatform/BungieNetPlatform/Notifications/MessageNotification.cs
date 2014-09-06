
namespace BungieNetPlatform.Notifications {
	public class MessageNotification {

		public User Sender;

		public override string ToString() {
			return string.Format(
				"{0} send you a new Private Message",
				Sender.DisplayName
			);
		}

	}
}
