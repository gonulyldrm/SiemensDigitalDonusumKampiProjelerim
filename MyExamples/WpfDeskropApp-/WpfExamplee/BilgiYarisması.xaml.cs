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
using System.Windows.Shapes;
using WpfExamplee.DatabaseConnection;
using WpfExamplee.Methods;

namespace WpfExamplee
{
    /// <summary>
    /// Interaction logic for BilgiYarisması.xaml
    /// </summary>
    public partial class BilgiYarisması : Window
    {
        int puan = 0;
        public BilgiYarisması()
        {
            InitializeComponent();
            this.Loaded += BilgiYarisması_Loaded;
        }

        private void BilgiYarisması_Loaded(object sender, RoutedEventArgs e)
        {
             GetQuestion();
        }


        private void btnA_Click(object sender, RoutedEventArgs e)
        {

            if (btnA.Content.ToString() == txtdogru.Text)
            {
                puan = puan + 10;
                puann.Text = puan.ToString();
            }
            GetQuestion();
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            if (btnB.Content.ToString() == txtdogru.Text)
            {
                puan = puan + 10;
                puann.Text = puan.ToString();
            }
            GetQuestion();
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            if (btnC.Content.ToString() == txtdogru.Text)
            {
                puan = puan + 10;
                puann.Text = puan.ToString();
            }
            GetQuestion();
        }
        public void GetQuestion()
        {

            SqlConnection connection = new SqlConnection(Database.GetConnectionString);
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from sorular order by NEWID() ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                btnA.Content= (oku["a"].ToString());
                btnB.Content = (oku["b"].ToString());
                btnC.Content = (oku["c"].ToString());
                txtsoru.Text = (oku["soru"].ToString());
                txtdogru.Text = (oku["dogru"].ToString());

            }
            connection.Close();
        }
    }
}
