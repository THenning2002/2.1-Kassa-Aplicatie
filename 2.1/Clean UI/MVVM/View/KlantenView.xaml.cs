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

namespace Clean_UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for KlantenView.xaml
    /// </summary>
    public partial class KlantenView : UserControl
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public KlantenView()
        {
            InitializeComponent();
            dg_klanten.ItemsSource = db.customers.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customer customer = new customer();
            customer.firstname = inv_first_name.Text;
            customer.lastname = inv_last_name.Text;
            customer.email = inv_email.Text;
            customer.phonenumber = inv_phonenumber.Text;
            customer.city = inv_city.Text;

            db.customers.InsertOnSubmit(customer);
            db.SubmitChanges();
            dg_klanten.ItemsSource = db.customers.ToList();
        }

        private void dg_klanten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var customer = (customer)dg_klanten.SelectedItem;
            inv_first_name.Text = customer.firstname;
            inv_last_name.Text = customer.lastname;
            inv_email.Text = customer.email;
            inv_city.Text = customer.city;
            inv_phonenumber.Text = customer.phonenumber;
        }

        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            var customer = (customer)dg_klanten.SelectedItem;
            customer.firstname = inv_first_name.Text;
            customer.lastname = inv_last_name.Text;
            customer.email = inv_email.Text;
            customer.city = inv_city.Text;
            customer.phonenumber = inv_phonenumber.Text;
            db.SubmitChanges();
        }
    }
}
