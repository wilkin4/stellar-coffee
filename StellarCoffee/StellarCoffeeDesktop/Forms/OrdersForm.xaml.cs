using StellarCoffeeData.Models;
using StellarCoffeeData.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// </summary>-
    public partial class OrdersForm : Window
    {
        public OrdersForm(Client client, List<Product> products)
        {
            InitializeComponent();

            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            string ncf = $"{letters[random.Next(0, letters.Length - 1)]}{letters[random.Next(0, letters.Length - 1)]}-{random.Next(0, letters.Length - 1)}{random.Next(0, letters.Length - 1)}{random.Next(0, letters.Length - 1)}{random.Next(0, letters.Length - 1)}";

            Client.Text = client.Name;

            RNC.Text = client.RNC;

            ReceiptType.Text = client.ReceiptType.Name;
            NCF.Text = ncf;
        }
    }
}
