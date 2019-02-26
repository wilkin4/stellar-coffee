using StellarCoffeeData.Models;
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
    public partial class HomeWindow : Window
    {
        public HomeWindow(User user)
        {
            InitializeComponent();

            UserName.Text = $"{user.Name} {user.LastName}";
        }

        private void ClientsButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void ProductsButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void ConfigurationsButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
