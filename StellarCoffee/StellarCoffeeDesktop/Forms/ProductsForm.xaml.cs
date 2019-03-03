using StellarCoffeeData.Models;
using StellarCoffeeData.Repositories.Entities;
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
    /// Interaction logic for ProductsForm.xaml
    /// </summary>
    public partial class ProductsForm : Window
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void SaveProductButtonClick(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = Name.Text;
            product.Price = float.Parse(Price.Text);
            product.ITBIS = float.Parse(ITBIS.Text);

            ProductRepostitory productRepostitory = new ProductRepostitory();

            productRepostitory.Create(product);

            this.Close();

            MessageBox.Show("Producto creado.");
        }
    }
}
