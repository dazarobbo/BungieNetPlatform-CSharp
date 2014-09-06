using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace BungieNetPlatform {

	[DataContract]
	public class User {

		[DataMember]
		public int MemberId;

		[DataMember]
		public string UniqueName;

		[DataMember]
		public string DisplayName;

		[DataMember]
		public int ProfilePicture;

		[DataMember]
		public int ProfileTheme;

		[DataMember]
		public int UserTitle;

		[DataMember]
		public int SuccessMessageFlags;

		[DataMember]
		public bool Deleted;

		[DataMember]
		public string About;

		[DataMember]
		public DateTime FirstAccess;

		[DataMember]
		public DateTime LastUpdate;

		[DataMember]
		public Context Context;

		[DataMember]
		public DateTime? BanExpiration;

		[DataMember]
		public string PsnDisplayName;

		[DataMember]
		public string XboxDisplayName;

		[DataMember]
		public bool ShowActivity;

		[DataMember]
		public int FollowerCount;

		[DataMember]
		public CultureInfo Locale;

		[DataMember]
		public bool LocaleInheritDefault;

		[DataMember]
		public string ProfilePicturePath;

		[DataMember]
		public string ProfileThemeName;

		[DataMember]
		public string UserTitleDisplay;


		public User() {

		}

		public User(JObject j) {
		
			MemberId = j["membershipId"].Value<int>();
			UniqueName = j["uniqueName"].Value<string>();
			DisplayName = j["displayName"].Value<string>();
			ProfilePicture = j["profilePicture"].Value<int>();
			ProfileTheme = j["profileTheme"].Value<int>();
			UserTitle = j["userTitle"].Value<int>();
			SuccessMessageFlags = j["successMessageFlags"].Value<int>();
			Deleted = j["isDeleted"].Value<bool>();
			About = j["about"].Value<string>();
			FirstAccess = j["firstAccess"].Value<DateTime>().ToUniversalTime();
			LastUpdate = j["lastUpdate"].Value<DateTime>().ToUniversalTime();

			if(j["context"] != null) {
				Context = new Context(j["context"].Value<JObject>());
			}

			//BanExpiration = ((DateTime)j["banExpireDate"]).ToLocalTime().ToUniversalTime();
			BanExpiration = j["banExpireDate"].Value<DateTime>().ToUniversalTime();

			//If 2001-01-01, there's no ban
			if(BanExpiration == new DateTime(2001, 1, 1, 0, 0, 0)) {
				BanExpiration = null;
			}

			PsnDisplayName = j["psnDisplayName"] != null
				? j["psnDisplayName"].Value<string>()
				: null;

			XboxDisplayName = j["xboxDisplayName"] != null
				? j["xboxDisplayName"].Value<string>()
				: null;

			ShowActivity = j["showActivity"].Value<bool>();
			FollowerCount = j["followerCount"].Value<int>();
			Locale = new CultureInfo((string)j["locale"]);
			LocaleInheritDefault = j["localeInheritDefault"].Value<bool>();
			ProfilePicturePath = j["profilePicturePath"].Value<string>();
			ProfileThemeName = j["profileThemeName"].Value<string>();
			UserTitleDisplay = j["userTitleDisplay"].Value<string>();

		}

		public override string ToString() {
			return DisplayName;
		}

	}
}
