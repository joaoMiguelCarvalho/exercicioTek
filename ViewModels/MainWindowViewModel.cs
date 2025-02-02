using Avalonia.Threading;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using exercicioTek.Models;
using ReactiveUI;
using Avalonia.Controls;

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

        private void OnDetailsClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var button = (Button)sender;
            var selectedInterface = button.DataContext as NetworkInterfaceModel;
            if (selectedInterface != null)
            {
                ToggleDetails(selectedInterface);
            }
        }

         public void ToggleDetails(NetworkInterfaceModel selectedInterface)
        {
            if (selectedInterface != null)
            {
                selectedInterface.IsExpanded = !selectedInterface.IsExpanded;
            }
        }

    }
}


