using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace exercicioTek.Models
{
	public class NetworkDataModel
	{
		// All Network Interfaces List
		public List<NetworkInterfaceModel> NetworkInterfacesData = [];

		public NetworkDataModel()
		{
			GetAllNetworkInterfaces();
		}

		private void GetAllNetworkInterfaces()
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

			// Run all network interfaces and store in a List<NetworkInterfaceModel>
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				string name = networkInterface.Name;
				var type = networkInterface.NetworkInterfaceType.ToString();
				var status = networkInterface.OperationalStatus.ToString();
				var macAddress = networkInterface.GetPhysicalAddress().ToString();
				List<string> listIPv4 = networkInterface.GetIPProperties().UnicastAddresses.Select(ip => ip.Address.ToString()).ToList();

				// Store all data in a list
				NetworkInterfacesData.Add(new NetworkInterfaceModel(name, type, status, macAddress, listIPv4));
			}
		}
	}
}
