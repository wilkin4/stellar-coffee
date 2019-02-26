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
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string password = Password.Password;

            UserRepository userRepository = new UserRepository();

            User user = userRepository.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrecta.");
            }
            else
            {
                HomeWindow homewindow = new HomeWindow(user);
                homewindow.Show();
                this.Close();
            }
        }
    }
}
