using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;

namespace exercicioTek.Models
{
    public class NetworkInterfaceModel : ReactiveObject
    {
        private string _name;
        private string _type;
        private string _status;
        private string _macAddress;
        private bool _isExpanded;
        private ObservableCollection<string> _listIPv4Adresses;

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        public string Type
        {
            get => _type;
            set => this.RaiseAndSetIfChanged(ref _type, value);
        }

        public string Status
        {
            get => _status;
            set => this.RaiseAndSetIfChanged(ref _status, value);
        }

        public string MacAddress
        {
            get => _macAddress;
            set => this.RaiseAndSetIfChanged(ref _macAddress, value);
        }

        public bool IsExpanded
        {
            get => _isExpanded;
            set => this.RaiseAndSetIfChanged(ref _isExpanded, value);
        }

        public ObservableCollection<string> ListIPv4Adresses
        {
            get => _listIPv4Adresses;
            set => this.RaiseAndSetIfChanged(ref _listIPv4Adresses, value);
        }

        public NetworkInterfaceModel(string name, string type, string status, string macAddress, List<string> listIPv4Adresses)
        {
            _name = name;
            _type = type;
            _status = status;
            _macAddress = macAddress;
            _listIPv4Adresses = new ObservableCollection<string>(listIPv4Adresses);
            _isExpanded = false;
        }
    }
}
