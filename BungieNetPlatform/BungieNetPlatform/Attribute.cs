using System.Runtime.Serialization;

namespace BungieNetPlatform {
	[DataContract]
	public class Attribute {

		[DataMember]
		public int Id;

		[DataMember]
		public int MinValue;

		[DataMember]
		public int MaxValue;


		public Attribute(int id, int minValue, int maxValue) {
			Id = id;
			MinValue = minValue;
			MaxValue = maxValue;
		}

	}
}
