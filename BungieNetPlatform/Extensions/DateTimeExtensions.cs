using System;

namespace Extensions {
	public static class DateTimeExtensions {

		/// <summary>
		/// Returns number of seconds since January 1st, 1970
		/// </summary>
		/// <param name="d"></param>
		/// <returns></returns>
		public static long ToUnixTimestamp(this DateTime d){
			TimeSpan ts = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1));
			return (long)ts.TotalSeconds;
		}

		public static string ToRelativeString(this DateTime d, DateTime accordingTo){

			const int SECOND = 1;
			const int MINUTE = 60 * SECOND;
			const int HOUR = 60 * MINUTE;
			const int DAY = 24 * HOUR;
			const int MONTH = 30 * DAY;

			TimeSpan ts = new TimeSpan(accordingTo.Ticks - d.Ticks);
			double delta = Math.Abs(ts.TotalSeconds);

			if(delta < 0) {
				return "not yet";
			}

			if(delta < 1 * MINUTE) {
				return ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";
			}

			if(delta < 2 * MINUTE) {
				return "a minute ago";
			}

			if(delta < 45 * MINUTE) {
				return ts.Minutes + " minutes ago";
			}

			if(delta < 90 * MINUTE) {
				return "an hour ago";
			}

			if(delta < 24 * HOUR) {
				return ts.Hours + " hours ago";
			}

			if(delta < 48 * HOUR) {
				return "yesterday";
			}

			if(delta < 30 * DAY) {
				return ts.Days + " days ago";
			}

			if(delta < 12 * MONTH) {
				int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
				return months <= 1 ? "one month ago" : months + " months ago";
			}

			else {
				int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
				return years <= 1 ? "one year ago" : years + " years ago";
			}

		}

		public static DateTime FromUnixTimestamp(long ts) {
			DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			return dtDateTime.AddSeconds(ts);
		}

	}
}
