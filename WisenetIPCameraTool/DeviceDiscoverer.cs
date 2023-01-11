using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Discovery;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WisenetIPCameraTool
{
	class DeviceDiscoverer
	{
		System.Threading.Timer onvifTmr;
		public delegate void DiscoverEventHandler(object sender, DiscoveredEventArgs e);
		public event DiscoverEventHandler Discover;
		public DeviceDiscoverer()
		{

		}

		public void Start()
		{
			onvifTmr = new System.Threading.Timer(OnvifCallback, null, 2000, 20000);
		}
		public void DiscoverNow()
		{
			OnvifCallback(null);
		}

		private async void OnvifCallback(object state)
		{
			var duration = TimeSpan.FromSeconds(20);
			var udpDiscoveryEndpoint = new UdpDiscoveryEndpoint(DiscoveryVersion.WSDiscoveryApril2005);
			var discoveryClient = new DiscoveryClient(udpDiscoveryEndpoint);
			discoveryClient.FindProgressChanged += (sender, e) =>
			{
				var address = e.EndpointDiscoveryMetadata.ListenUris.FirstOrDefault(lu => lu.Host.StartsWith("192.168"));
				if (address == null)
				{
					return;
				}
				SetIpAddress(address.Host);
			};

			try
			{
				var findCriteria = new FindCriteria { Duration = duration, MaxResults = 100 };
				findCriteria.ContractTypeNames.Add(new XmlQualifiedName("NetworkVideoTransmitter", "http://www.onvif.org/ver10/network/wsdl"));

				discoveryClient.FindAsync(findCriteria);
				await Task.Delay(duration);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				if (discoveryClient != null)
				{
					discoveryClient.Close();
					discoveryClient = null;
				}

			}
		}

		public class DiscoveredEventArgs : EventArgs
		{
			public string IpAddress { get; set; }
		}

		public void SetIpAddress(string ip)
		{
			DiscoveredEventArgs args = new DiscoveredEventArgs();
			args.IpAddress = ip;
			Discoverd(args);
		}

		protected virtual void Discoverd(DiscoveredEventArgs e)
		{
			if (Discover != null)
			{
				Discover(this, e);
			}
		}

	}
}
