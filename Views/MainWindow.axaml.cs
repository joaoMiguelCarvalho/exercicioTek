using Avalonia.Controls;
using System;
using System.Threading.Tasks;
using exercicioTek.ViewModels;
using exercicioTek.Models;

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

         private async void OnDetailsClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Chama a função de atualização da UI
            await _viewModel.RefreshAsync();
        }
    }
}

