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
    /// Interaction logic for ClientsForm.xaml
    /// </summary>
    public partial class ClientsForm : Window
    {
        public ClientsForm()
        {
            InitializeComponent();

            ReceiptTypeRepository receiptTypeRepository = new ReceiptTypeRepository();
            Expression<Func<ReceiptType, bool>> predicate = rt => rt.Status == true;
            IEnumerable<ReceiptType> receiptTypes = receiptTypeRepository.GetAll(predicate);

            foreach(ReceiptType receiptType in receiptTypes)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = receiptType.Name;
                comboBoxItem.DataContext = receiptType;

                ReceiptTypes.Items.Add(comboBoxItem);
            }
        }

        private void SaveClientButtonClick(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedReceiptType = ReceiptTypes.SelectedItem as ComboBoxItem;
            ReceiptType receiptType = selectedReceiptType.DataContext as ReceiptType;

            Client client = new Client();
            client.ReceiptTypeId = receiptType.Id;
            client.Name = Name.Text;
            client.IdentityCardNumber = IdentityCardNumber.Text;
            client.RNC = RNC.Text;
            client.Address = Address.Text;

            ClientRepository clientRepository = new ClientRepository();

            clientRepository.Create(client);

            this.Close();

            MessageBox.Show("Cliente creado.");
        }
    }
}
