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
        public ObservableCollection<string> ListIPv4Adresses { get; } = new();
        private bool _isExpanded;
             
        public bool IsExpanded
        {
            get => _isExpanded;
            set => this.RaiseAndSetIfChanged(ref _isExpanded, value);
        }
        private string _newIPv4;
        public string NewIPv4
        {
	        get => _newIPv4;
	        set => this.RaiseAndSetIfChanged(ref _newIPv4, value);
        }
        private string _editIPv4;
        public string EditIPv4
        {
	        get => _editIPv4;
	        set => this.RaiseAndSetIfChanged(ref _editIPv4, value);
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
