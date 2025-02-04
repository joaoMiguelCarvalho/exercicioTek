/*using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using exercicioTek.Models;
using System.Linq;

namespace exercicioTek.Views
{
    public partial class DetailsWindow : Window
    {
        public DetailsWindow(NetworkInterfaceModel selectedInterface)
        {
            InitializeComponent();

            if(selectedInterface != null)
            {
                DataContext = selectedInterface; // Define o DataContext como a interface selecionada
                // Exibir detalhes do IPv4
                //var ipv4Addresses = string.Join(", ", selectedInterface.ListIPv4Adresses);
                //var ipv4TextBlock = this.FindControl<TextBlock>("IPv4Details");
                //ipv4TextBlock.Text = ipv4Addresses;
            }
           
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}*/
