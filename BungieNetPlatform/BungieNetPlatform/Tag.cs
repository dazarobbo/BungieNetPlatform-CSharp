using System.Runtime.Serialization;

namespace BungieNetPlatform {

	[DataContract]
	public class Tag {

		[DataMember]
		string Value;

		[DataMember]
		public IgnoreStatus IgnoreStatus;


		public static implicit operator Tag (string v){
			return new Tag(v);
		}

		public static implicit operator string(Tag t) {
			return t.Normalized;
		}

		public Tag(string value) {
			Value = value;
		}

		public string Raw {
			get { return Value; }
		}

		public string Normalized {
			get {
				return Value ?? Value.ToLower().Replace("#", "");
			}
		}

		public override string ToString() {
			return Normalized;
		}

	}
}
