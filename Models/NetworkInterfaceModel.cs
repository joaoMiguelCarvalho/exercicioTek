using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;

namespace exercicioTek.Models
{
    public class NetworkInterfaceModel : ReactiveObject
    {
        public string Name { get; init; }
        public string Type { get; init; }
        public string Status { get; init; }
        public string MacAddress { get; init; }
        private bool _isExpanded;
        public ObservableCollection<string> ListIPv4Adresses { get; } = new();
             
        public bool IsExpanded
        {
            get => _isExpanded;
            set => this.RaiseAndSetIfChanged(ref _isExpanded, value);
        }

        public NetworkInterfaceModel(string name, string type, string status, string macAddress, IEnumerable<string> listIPv4Adresses)
        {
            Name = name;
            Type = type;
            Status = status;
            MacAddress = macAddress;
            ListIPv4Adresses = new ObservableCollection<string>(listIPv4Adresses);
            _isExpanded = false;
        }
    }
}
