using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace KutuphaneWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameLastname = "",kitapName="";
        int kitapBaski = 0 ;
        DateTime? dateTime;
        bool onay = false;
        Kitap kitap = null;       
        
        Kutuphane kutuphane=null;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            btnKaydett.Click += BtnKaydet_Click;
            
        }
 
        List<Kutuphane> KutuphaneGetir()
        {
            List<Kutuphane> kutuphanes = new List<Kutuphane>();
            kutuphanes.Add(new Kutuphane(1,"basaksehir Kutuphanesi",15,150));
            kutuphanes.Add(new Kutuphane(2, "ahmet yesevi Kutuphanesi", 50, 190));
            kutuphanes.Add(new Kutuphane(5, "abc Kutuphanesi", 11, 80));
            return kutuphanes;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cmbKutuphaneler.ItemsSource = KutuphaneGetir();
            cmbKutuphaneler.DisplayMemberPath = "Name";
            cmbKutuphaneler.SelectedValuePath = "Id";
            cmbKutuphaneler.SelectedValuePath = "Koltuksayisi"; 
             cmbKutuphaneler.SelectedValuePath = "Masasayisi";
        }

        public void GetDataFromKitap()
        {
            nameLastname = txtkitapAd.Text;

            kitapName = txtkitapAd.Text;
            kitapBaski = int.Parse(txtbaski.Text);
            dateTime = DogumTarihi.SelectedDate;
            onay = (bool)chckOnay.IsChecked ? true : false;
            if (cmbKutuphaneler.SelectedItem != null)
            {
                kutuphane = (Kutuphane)cmbKutuphaneler.SelectedItem;
            }

        }
        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            string yazi;
            GetDataFromKitap();
            Kitap kitap = new Kitap(2,kitapName,kitapBaski);
            
            Yazar yazar = new Yazar();
            yazar.NameLastname = nameLastname;
            yazar.Onay = onay;
            yazar.Kitap = kitap;
            yazar.Kutuphane = kutuphane;
            yazar.DateTimebirthday = dateTime.Value;
            yazi = yazar.NameLastname + yazar.Kitap.Name + yazar.Kutuphane.Name+yazar.DateTimebirthday+yazar.Onay;
           // MessageBox.Show(yazar.NameLastname + yazar.Kitap.Name+yazar.Kutuphane.Name);
            
            
            lst.Items.Add(yazi);
        }

    }
}
