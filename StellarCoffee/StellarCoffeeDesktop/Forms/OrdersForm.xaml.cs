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

namespace StellarCoffeeDesktop.Forms
{
    /// <summary>
    /// Interaction logic for OrdersForm.xaml
    /// </summary>
    public partial class OrdersForm : Window
    {
        public OrdersForm(Client client, List<Product> products)
        {
            InitializeComponent();
        }
    }
}
