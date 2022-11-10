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
    /// Interaction logic for ProductenView.xaml
    /// </summary>
    public partial class ProductenView : UserControl
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public ProductenView()
        {
            InitializeComponent();
            dg_producten.ItemsSource = db.products.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //van string naar int
            string sproduct_type = inv_product_type_id.Text;
            int iproduct_type = Int32.Parse(sproduct_type);

            //van string naar double(coma getal)
            string ssprice = inv_price.Text; 
            double iprice = double.Parse(ssprice);

            product product = new product();
            product.productName = inv_product_name.Text;
            product.producttypeID = iproduct_type;
            product.prijs = iprice;

            db.products.InsertOnSubmit(product);
            db.SubmitChanges();
        }

        private void dg_producten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = (product)dg_producten.SelectedItem;
            inv_product_name.Text = product.productName;
            inv_product_type_id.Text = product.producttypeID.ToString();
            inv_price.Text = product.prijs.ToString();
        }

        private void btn_change_Click(object sender, RoutedEventArgs e)
        {

            //van string naar int
            string sproduct_type = inv_product_type_id.Text;
            int iproduct_type = Int32.Parse(sproduct_type);

            //van string naar double(coma getal)
            string ssprice = inv_price.Text;
            double iprice = double.Parse(ssprice);

            var product = (product)dg_producten.SelectedItem;
            product.productName = inv_product_name.Text;
            product.producttypeID = iproduct_type;
            product.prijs = iprice;
            //product.productName = "Cherry";
            //product.producttypeID = 42;
            //product.prijs = 1.5;
            db.SubmitChanges();
        }
    }
}
