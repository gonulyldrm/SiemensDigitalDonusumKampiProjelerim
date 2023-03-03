using System;
using System.Collections.Generic;
using System.Data;
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
using WpfExamplee.Methods;

namespace WpfExamplee
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Product> products = new List<Product>();
        public Window1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, RoutedEventArgs e)
        {
            fiyatfilt20.Visibility = Visibility.Hidden;
            fiyatfilt20p.Visibility = Visibility.Hidden;
            Count.Visibility = Visibility.Hidden;
            chckStok.Visibility = Visibility.Hidden;
            txtNameOrID.Visibility = Visibility.Hidden;
            txtNameOrIDD.Visibility = Visibility.Hidden;
            btnADD2.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            txtStock.Visibility = Visibility.Hidden;
            txtUnitPrice.Visibility = Visibility.Hidden;
            txtunitpricee.Visibility = Visibility.Hidden;
            txtstokk.Visibility = Visibility.Hidden;
         
          
          
            datagridDetails.ItemsSource = Method.GetProducts();

        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {

            fiyatfilt20.Visibility = Visibility.Visible;
            fiyatfilt20p.Visibility = Visibility.Visible;
            Count.Visibility = Visibility.Visible;
            chckStok.Visibility = Visibility.Visible;
            txtNameOrID.Visibility = Visibility.Hidden;
            txtNameOrIDD.Visibility = Visibility.Hidden;
            btnADD2.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            txtStock.Visibility = Visibility.Hidden;
            txtUnitPrice.Visibility = Visibility.Hidden;
            txtunitpricee.Visibility = Visibility.Hidden;
            txtstokk.Visibility = Visibility.Hidden;
        }

        private void fiyatfilt20_Checked(object sender, RoutedEventArgs e)
        {
            if (fiyatfilt20.IsChecked == true)
            {
                datagridDetails.ItemsSource = Method.GetProductsUnitPrice20();
            }

        }

        private void fiyatfilt20p_Checked(object sender, RoutedEventArgs e)
        {
            if (fiyatfilt20p.IsChecked == true)
            {
                datagridDetails.ItemsSource = Method.GetProductsUnitPrice20plus();
            }
        }

        private void Count_Checked(object sender, RoutedEventArgs e)
        {
            if (Count.IsChecked == true)
            {
                datagridDetails.ItemsSource = Method.GetProductUnitPrice50_80();
            }

        }

        private void chckStok_Checked(object sender, RoutedEventArgs e)
        {
            if (chckStok.IsChecked == true)
            {
                datagridDetails.ItemsSource = Method.GetProductsNoStock();
            }

        }

        private void btnDeletee_Click(object sender, RoutedEventArgs e)
        {

            txtNameOrIDD.Clear();
            txtNameOrID.Text = "ID";
            fiyatfilt20.Visibility = Visibility.Hidden;
            fiyatfilt20p.Visibility = Visibility.Hidden;
            Count.Visibility = Visibility.Hidden;
            chckStok.Visibility = Visibility.Hidden;
            txtNameOrID.Visibility = Visibility.Visible;
            txtNameOrIDD.Visibility = Visibility.Visible;
            btnADD2.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Visible;
            txtStock.Visibility = Visibility.Hidden;
            txtUnitPrice.Visibility = Visibility.Hidden;
            txtunitpricee.Visibility = Visibility.Hidden;
            txtstokk.Visibility = Visibility.Hidden;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            txtNameOrID.Text = "Name";
            fiyatfilt20.Visibility = Visibility.Hidden;
            fiyatfilt20p.Visibility = Visibility.Hidden;
            Count.Visibility = Visibility.Hidden;
            chckStok.Visibility = Visibility.Hidden;
            txtNameOrID.Visibility = Visibility.Visible;
            txtNameOrIDD.Visibility = Visibility.Visible;
            btnADD2.Visibility = Visibility.Visible;
            btnDelete.Visibility = Visibility.Hidden;
            txtStock.Visibility = Visibility.Visible;
            txtUnitPrice.Visibility = Visibility.Visible;
            txtunitpricee.Visibility = Visibility.Visible;
            txtstokk.Visibility = Visibility.Visible;
        }

        private void btnADD2_Click(object sender, RoutedEventArgs e)
        {
            int stock = Convert.ToInt32(txtStock.Text);
            string name = txtNameOrIDD.Text;
            int price = Convert.ToInt32(txtUnitPrice.Text);


            bool result = Method.ProductAdd(name, price, stock);

            if (result)
            {
                MessageBox.Show("İşlem başarılı.");
            }
            else
            {
                MessageBox.Show("İşlem başarısız.");
            }
            datagridDetails.ItemsSource = Method.GetProducts();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            int id = int.Parse(txtNameOrIDD.Text);


            bool result = Method.ProductDelete(id);

            if (result)
            {
                MessageBox.Show("İşlem başarılı.");
            }
            else
            {
                MessageBox.Show("İşlem başarısız.");
            }
            datagridDetails.ItemsSource = Method.GetProducts();
        }

        private void btnBilgiY_Click(object sender, RoutedEventArgs e)
        {
            BilgiYarisması bilgi = new BilgiYarisması();
            bilgi.Show();
        }
    }
}
