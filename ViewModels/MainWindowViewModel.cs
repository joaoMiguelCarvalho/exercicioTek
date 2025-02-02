using Avalonia.Threading;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using exercicioTek.Models;
using ReactiveUI;

namespace exercicioTek.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<NetworkInterfaceModel> NetworkInterfaces { get; set; }

        private NetworkInterfaceModel? _selectedInterface;
        public NetworkInterfaceModel? SelectedInterface
        {
            get => _selectedInterface;
            set => this.RaiseAndSetIfChanged(ref _selectedInterface, value);
        }

        public MainWindowViewModel(NetworkDataModel networkDataModel)
        {
            NetworkInterfaces = new ObservableCollection<NetworkInterfaceModel>(networkDataModel.NetworkInterfacesData);
        }

        /// <summary>
        /// Method for Refresh Button
        /// </summary>
        public async Task RefreshAsync()
        {
            
            await Task.Delay(1000);  

            // Update UI with the main thread
            await Dispatcher.UIThread.InvokeAsync(() =>
            {
                // TODO: The refresh is not updating
                var newNetworkDataModel = new NetworkDataModel();
				NetworkInterfaces = new ObservableCollection<NetworkInterfaceModel>(newNetworkDataModel.NetworkInterfacesData);
            });
        }
    }
}


