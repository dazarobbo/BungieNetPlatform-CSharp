using System;
using System.ServiceModel;

namespace Extensions {
	public class PipeConnection<T> {

		public T Proxy { get; private set; }

		public PipeConnection(string endpoint) {

			NetNamedPipeBinding binding = new NetNamedPipeBinding();
			binding.CloseTimeout = TimeSpan.MaxValue;
			binding.OpenTimeout = TimeSpan.MaxValue;
			binding.ReceiveTimeout = TimeSpan.MaxValue;
			binding.SendTimeout = TimeSpan.MaxValue;

			ChannelFactory<T> factory = new ChannelFactory<T>(
				binding,
				new EndpointAddress(endpoint)
			);

			Proxy = factory.CreateChannel();
			IContextChannel channelContext = (IContextChannel)Proxy;
			channelContext.OperationTimeout = new TimeSpan(0, 25, 0);

		}

	}
}
