using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using WpfExamplee;
using WpfExamplee.DatabaseConnection;
using WpfExamplee.Methods;

namespace WpfExamplee
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

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            bool result= Method.Login(txtfirstname.Text,txtlastname.Text);
            if (result)
            {
                MessageBox.Show("basarılı");
                Window1 main = new Window1();
                main.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("tekrar dene");
                txtfirstname.Clear();
                txtlastname.Clear();    
            }
        }

      

        private void txtfirstname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
