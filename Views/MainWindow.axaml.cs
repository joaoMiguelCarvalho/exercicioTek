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



        /// <summary>
        /// Refresh ClicK Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnRefreshClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Calls the UI update function
            await _viewModel.RefreshAsync();
        }
        
        /// <summary>
		/// Details ClicK Method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void OnDetailsClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            
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

/*
        private void OnDeleteIPv4Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (_viewModel.SelectedInterface != null)
            {
                var button = (Button)sender;
                string? selectedIP = button.Tag as string;
                Console.WriteLine("selected ip is not null");

                if (selectedIP != null)
                {
                    _viewModel.SelectedInterface.ListIPv4Adresses.Remove(selectedIP);
                    Console.WriteLine("selected ip is not null");
                }
            }
        }*/

        /// <summary>
		/// Delete ClicK Method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void OnDeleteIPv4Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (_viewModel.SelectedInterface == null)
            {
                Console.WriteLine("No interfaces selected.");
                return;
            }

            var button = sender as Button;
            if (button == null)
            {
                Console.WriteLine("Error: button is null.");
                return;
            }

            if (button.Tag is not string selectedIP)
            {
                Console.WriteLine("Error: Button tag is null or does not contain a valid IP.");
                return;
            }

            Console.WriteLine($"Trying to remove IP: {selectedIP}");

            if (_viewModel.SelectedInterface.ListIPv4Adresses.Contains(selectedIP))
            {
                _viewModel.SelectedInterface.ListIPv4Adresses.Remove(selectedIP);
                Console.WriteLine("IP removed successfully.");
            }
            
        }


        /// <summary>
		/// Add ClicK Method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void OnAddIPv4Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
	        if (_viewModel.SelectedInterface == null)
	        {
		        return;
	        }
			
	        if (_viewModel.SelectedInterface.NewIPv4 != "")
	        {
		        _viewModel.SelectedInterface.ListIPv4Adresses.Add(_viewModel.SelectedInterface.NewIPv4);
		        _viewModel.SelectedInterface.NewIPv4 = "";
	        }
        }

		/// <summary>
		/// Edit ClicK Method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void OnEditIPv4Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
			if (_viewModel.SelectedInterface == null)
			{
				return;
			}
			
			var button = sender as Button;

			if (button == null)
			{
				return;
			}

			if (button.Tag is not string selectedIP)
			{
				return;
			}

			var newIPv4Address = "NewEditValue";

			_viewModel.SelectedInterface.ListIPv4Adresses.Remove(selectedIP);
			_viewModel.SelectedInterface.ListIPv4Adresses.Add(newIPv4Address);
		}    
    }
}

