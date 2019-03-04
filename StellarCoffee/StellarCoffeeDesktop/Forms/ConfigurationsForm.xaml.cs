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
    /// Interaction logic for ConfigurtionsForm.xaml
    /// </summary>
    public partial class ConfigurationsForm : Window
    {
        private int _userId;

        public ConfigurationsForm(int userId)
        {
            InitializeComponent();

            _userId = userId;

            UserRepository userRepository = new UserRepository();
            Expression<Func<User, bool>> predicate = User => User.Id == userId;
            User user = userRepository.Get(predicate);

            UserName.Text = user.UserName;
            Name.Text = user.Name;
            LastName.Text = user.LastName;
        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Id = _userId;
            user.UserName = UserName.Text;
            user.Name = Name.Text;
            user.LastName = LastName.Text;
            user.Password = Password.Password;

            UserRepository userRepository = new UserRepository();

            userRepository.Update(user);

            MessageBox.Show("Actualización exitosa.");
        }
    }
}
