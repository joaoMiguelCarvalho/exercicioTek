using Avalonia.Controls;
using System;
using System.Threading.Tasks;
using exercicioTek.ViewModels;
using exercicioTek.Models;
using ReactiveUI;

namespace exercicioTek.Views
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel(new NetworkDataModel());
            DataContext = _viewModel;
        }



        // Método que será chamado ao clicar no botão
        private async void OnRefreshClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Chama a função de atualização da UI
            await _viewModel.RefreshAsync();
        }

        private void OnDetailsClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Verifica se há uma interface selecionada
            var button = (Button)sender;
            var selectedInterface = button.DataContext as NetworkInterfaceModel;
            if (selectedInterface != null)
                {
                    _viewModel.ToggleDetails(selectedInterface);
                }
            else
                {
                    Console.WriteLine("Nenhuma interface selecionada."); // Debug
                }
        }


        private void OnDeleteIPv4Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (_viewModel.SelectedInterface != null)
            {
                var button = (Button)sender;
                string selectedIP = button.Tag as string;

                if (selectedIP != null)
                {
                    _viewModel.SelectedInterface.ListIPv4Adresses.Remove(selectedIP);
                }
            }
        }

        private async void OnEditIPv4Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            
        }



    }
}

