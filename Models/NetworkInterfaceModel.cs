using System.Collections.Generic;

namespace exercicioTek.Models
{
    public class NetworkInterfaceModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string MacAddress { get; set; }
        public List<string> ListIPv4Adresses { get; set; }

        public NetworkInterfaceModel(string name, string type, string status, string macAddress, List<string> listIPv4Adresses)
        {
            Name = name;
            Type = type;
            Status = status;
            MacAddress = macAddress;
            ListIPv4Adresses = listIPv4Adresses;
        }
    }
}