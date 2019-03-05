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

            SearchProducts("");
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

        private void SearchProductsButtonClick(object sender, RoutedEventArgs e)
        {
            SearchProducts(ProductStringSearch.Text);
        }

        private void SearchClientsButtonClick(object sender, RoutedEventArgs e)
        {
            SearchClients(ClientStringSearch.Text);
        }

        private void SearchClients(string stringSearch)
        {
            ClientRepository clientRepository = new ClientRepository();

            IEnumerable<Client> clients = clientRepository.Search(stringSearch);

            Clients.Items.Clear();

            foreach (Client client in clients)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = client.Name;

                Clients.Items.Add(listBoxItem);
            }
        }

        private void SearchProducts(string stringSearch)
        {
            ProductRepostitory productRepostitory = new ProductRepostitory();

            IEnumerable<Product> products = productRepostitory.Search(stringSearch);

            Products.Items.Clear();

            foreach (Product product in products)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = product.Name;

                Clients.Items.Add(listBoxItem);
            }
        }
    }
}
