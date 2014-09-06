using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Net;
using System.Linq;
using BungieNetPlatform.Enums;
using Newtonsoft.Json.Linq;
using Extensions;

namespace BungieNetPlatform {

	[DataContract]
	public class RequestingUser : CurrentUser {

		private const int DefaultTimeout = 8000;
		private const string DefaultUserAgent = "Netscape Navigator";

		[DataMember]
		public string UserAgent;

		[DataMember]
		public TimeSpan Timeout;

		[DataMember]
		public ICollection<Cookie> Cookies;

		[DataMember]
		public string CsrfToken {
			get {

				Cookie c = Cookies.Where(cc => cc.Name == "bungled").SingleOrDefault();

				if(c == null) {
					return null;
				}

				return c.Value;

			}
			set {

			}
		}



		public RequestingUser(int timeout = DefaultTimeout, string userAgent = DefaultUserAgent) {
			Cookies = new List<Cookie>();
			Timeout = new TimeSpan(0, 0, 0, 0, timeout);
			UserAgent = userAgent;
		}


	}
}
