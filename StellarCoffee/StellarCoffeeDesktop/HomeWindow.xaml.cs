using StellarCoffeeData.Models;
using StellarCoffeeData.Repositories.Entities;
using StellarCoffeeDesktop.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StellarCoffeeDesktop
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    /// 
    public partial class HomeWindow : Window
    {
        private int _userId;

        public HomeWindow(User user)
        {
            InitializeComponent();

            _userId = user.Id;

            UserName.Text = $"{user.Name} {user.LastName}";

            SearchClients("");
        }

        private void ClientsButtonClick(object sender, RoutedEventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }

        private void ProductsButtonClick(object sender, RoutedEventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void ConfigurationsButtonClick(object sender, RoutedEventArgs e)
        {
            ConfigurationsForm configurationsForm = new ConfigurationsForm(_userId);
            configurationsForm.ShowDialog();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            SearchClients(StringSearch.Text);
        }

        private void SearchClients(string stringSearch)
        {
            ClientRepository clientRepository = new ClientRepository();

            IEnumerable<Client> clients = clientRepository.Search(stringSearch);

            Clients.Items.Clear();

            foreach (Client client in clients)
            {
                Clients.Items.Add(client.Name);
            }
        }
    }
}
