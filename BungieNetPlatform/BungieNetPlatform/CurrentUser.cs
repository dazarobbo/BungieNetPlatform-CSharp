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
	public class CurrentUser : User {

		[DataMember]
		public bool AdultMode;

		[DataMember]
		public ICollection<Group> Clans;

		[DataMember]
		public string Email;

		[DataMember]
		public int EmailStatus; //enum?

		[DataMember]
		public int EmailUsage; //enum?

		[DataMember]
		public ICollection<Group> FoundedGroups;

		[DataMember]
		public bool LightTheme;

		[DataMember]
		public string PsnId;

		[DataMember]
		ICollection<BungieCredentialType> PublicCredentialTypes;

		[DataMember]
		public bool ShowFacebookPublic;

		[DataMember]
		public bool ShowGamertagPublic;

		[DataMember]
		public bool ShowPsnPublic;

		[DataMember]
		public ICollection<Acl> Acls;

		[DataMember]
		public int ResearchStatusFlags;


		private void _Initialise() {
			Clans = new List<Group>();
			FoundedGroups = new List<Group>();
			PublicCredentialTypes = new List<BungieCredentialType>();
			Acls = new List<Acl>();
		}


		public CurrentUser() {
			_Initialise();
		}

		public CurrentUser(JObject j) : base(j) {

			_Initialise();

			AdultMode = j["adultMode"].Value<bool>();
			j["clans"].Cast<JObject>().ForEach(c => Clans.Add(new Group(c)));
			Email = j["email"].Value<string>();
			EmailStatus = j["emailStatus"].Value<int>();
			EmailUsage = j["emailUsage"].Value<int>();
			j["foundedGroups"].Cast<JObject>().ForEach(g => FoundedGroups.Add(new Group(g)));
			LightTheme = j["isThemeLight"].Value<bool>();
			PsnId = j["psnId"].Value<string>();
			j["publicCredentialTypes"].Cast<int>().Cast<BungieCredentialType>().ForEach(c => PublicCredentialTypes.Add(c));
			ShowFacebookPublic = j["showFacebookPublic"].Value<bool>();
			ShowGamertagPublic = j["showGamertagPublic"].Value<bool>();
			//user object isn't needed, this class is derived
			j["userAcls"].Cast<int>().Cast<Acl>().ForEach(a => Acls.Add(a));
			ResearchStatusFlags = j["userResearchStatusFlags"].Value<int>();

		}

	}
}
