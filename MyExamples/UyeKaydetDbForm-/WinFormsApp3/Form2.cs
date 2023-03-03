using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection();

        public Form2()
        {

           
            InitializeComponent();
            var str= "Data Source=.\\SQLExpress;Initial Catalog=UyeDb;Integrated Security=SSPI";
            connection.ConnectionString= str;   
        }

        private void btnKaydet_Click(object sender, EventArgs e)

        {

            connection.Open();
            SqlCommand ekle = new SqlCommand("insert into Uyeler (Id,adsoyad,telefon,kullaniciad,email,sifre,sehir) values (@id,@a,@t,@k,@e,@s,@se)", connection);
            int ID = int.Parse(txtId.Text);

            ekle.Parameters.AddWithValue("@id", ID);
            ekle.Parameters.AddWithValue("@a", txtAdsoyad.Text);
            ekle.Parameters.AddWithValue("@t", txtTelefon.Text);
            ekle.Parameters.AddWithValue("@k", txtKullaniciad.Text);
            ekle.Parameters.AddWithValue("@e", txtEmail.Text);
            ekle.Parameters.AddWithValue("@s", txtSifre.Text);
            ekle.Parameters.AddWithValue("@se", cmbSehir.Text);

            ekle.ExecuteNonQuery();

            connection.Close();
            VeriGoruntule();
        }
        private void VeriGoruntule()
        {
            lswUyelerGoster.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Uyeler", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["Kullaniciad"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());
                ekle.SubItems.Add(oku["sehir"].ToString());

                lswUyelerGoster.Items.Add(ekle);

            }
            connection.Close();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            VeriGoruntule();
        }

        private void chckOnay_CheckedChanged(object sender, EventArgs e)
        {
            if (chckOnay.Checked)
            {
                btnKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
