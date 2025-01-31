namespace exercicioTek.Models
{
    public class NetworkInterfaceModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string MacAddress { get; set; }

        public NetworkInterfaceModel(string name, string type, string status, string macAddress)
        {
            Name = name;
            Type = type;
            Status = status;
            MacAddress = macAddress;
        }
    }
}