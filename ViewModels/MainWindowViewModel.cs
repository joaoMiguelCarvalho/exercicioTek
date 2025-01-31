using Avalonia.Threading;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using exercicioTek.Models;
using ReactiveUI;

namespace exercicioTek.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<NetworkInterfaceModel> NetworkInterfaces { get; } = new();

        private NetworkInterfaceModel? _selectedInterface;
        public NetworkInterfaceModel? SelectedInterface
        {
            get => _selectedInterface;
            set => this.RaiseAndSetIfChanged(ref _selectedInterface, value);
        }

        public MainWindowViewModel()
        {
            // Não precisamos mais do ICommand
        }

        // Método que será chamado diretamente ao clicar no botão
        public async Task RefreshAsync()
        {
            // Simula uma operação assíncrona para obter as interfaces de rede
            await Task.Delay(1000);  

            // Atualiza a UI de forma segura na thread principal
            await Dispatcher.UIThread.InvokeAsync(() =>
            {
                // Limpa a lista de interfaces e adiciona novas
                NetworkInterfaces.Clear();
                NetworkInterfaces.Add(new NetworkInterfaceModel("eth0", "Ethernet", "Up", "AA:BB:CC:DD:EE:FF"));
                NetworkInterfaces.Add(new NetworkInterfaceModel("wlan0", "Wi-Fi", "Down", "11:22:33:44:55:66"));
            });
        }
    }
}


