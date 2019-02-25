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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StellarCoffeeDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Product product = new Product();
            product.Id = 3;
            product.Name = "Super expresso";
            product.Price = 100;
            product.Status = true;

            ProductRepostitory productRepostitory = new ProductRepostitory();

            Expression<Func<Product, bool>> predicate = Product => Product.Id == 3 && Product.Status == true;

            productRepostitory.Update(product);

            //productRepostitory.Delete(2);

            //productRepostitory.Create(product);

            //Expression<Func<Product, bool>> predicate = Product => Product.Status == true;

            //IEnumerable<Product> products = productRepostitory.GetAll(predicate);

            InitializeComponent();
        }
    }
}
