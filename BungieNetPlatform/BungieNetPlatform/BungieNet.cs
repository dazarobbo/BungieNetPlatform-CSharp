using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
using Extensions;

//Import tool
//http://jsbin.com/hohuzaqocati/7/edit

namespace BungieNetPlatform {
	public static class BungieNet {

		public static string Protocol = "https";
		public const string Domain = "bungie.net";
		public static string Host {
			get {
				return "www." + Domain;
			}
		}
		public static string Base {
			get {
				return Protocol + "://" + Host;
			}
		}
		public static string PlatformPath {
			get {
				return Base + "/Platform";
			}
		}

		public const char BlankChar = '\u00ad';

		public const int MinPostLength = 2;
		public const int MaxPostLength = 10000;

		public const int PostWaitTime = 10;
		public const int CreateTopicWaitTime = 20;
		public const int LikeWaitTime = 3;

		public const int ForumItemsPerPage = 25;

		public static string BlankPost {
			get {
				return new string(BlankChar, MinPostLength);
			}
		}

		public static string FixUrl(string url) {

			//URI class may work, but it throws exceptions on bad formats
			throw new NotImplementedException();

		}

	}
}
