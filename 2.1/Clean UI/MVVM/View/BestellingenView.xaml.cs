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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clean_UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for Bestellingen.xaml
    /// </summary>
    public partial class BestellingenView : UserControl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public BestellingenView()
        {
            InitializeComponent();
            dg_bestellingen.ItemsSource = db.orders.ToList();
        }

        private void inv_klant_id_loaded(object sender, RoutedEventArgs e)
        {
            //order order = new order();
            //ComboBox inv_klant = new ComboBox();
           // inv_klant = order.costumerID.ToString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string sklant_id = inv_klant_id.Text;
            int iklant_id = Int32.Parse(sklant_id);

            
            
            order order = new order();

            order.date = (DateTime)d_datum.SelectedDate;
            order.costumerID = iklant_id;

            db.orders.InsertOnSubmit(order);
            db.SubmitChanges();
        }

        private void dg_bestellingen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orders = (order)dg_bestellingen.SelectedItem;
            inv_klant_id.Text=orders.costumerID.ToString();
            d_datum.Text = orders.date.ToString();
        }

        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            string sklant_id = inv_klant_id.Text;
            int iklant_id = Int32.Parse(sklant_id);


            order order = new order();
            //order.date = d_datum.Date;
            order.costumerID = iklant_id;

            db.SubmitChanges();
        }
    }
}
