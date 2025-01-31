using Avalonia.Controls;
using System;
using System.Threading.Tasks;
using exercicioTek.ViewModels;

namespace exercicioTek.Views
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;
        }



        // Método que será chamado ao clicar no botão
        private async void OnRefreshClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Chama a função de atualização da UI
            await _viewModel.RefreshAsync();
        }
    }
}

