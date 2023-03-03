using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsApp6.Helper;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Sehir _SehirS;
        public Form1()
        {
            InitializeComponent();
            _SehirS= new Sehir();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                cmbSehir.Items.Add("İstanbul");
                cmbSehir.Items.Add("Ankara");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cmbMahalle.Items.Clear();
                string ilcee = cmbIlce.Text;
                if (!StringHelpers.CheckIfEmpty(ilcee))

                {
                    string ilcepwd = EncryptionHelper.Encrypt(ilcee);
                    bool kayit = _SehirS.Kayit2(ilcee);
                    if (kayit)
                    {
                        if (cmbIlce.SelectedIndex == 0)
                        {
                            cmbMahalle.Items.Add("a");
                            cmbMahalle.Items.Add("b");
                            cmbMahalle.Items.Add("c");
                        }
                        else if (cmbIlce.SelectedIndex == 1)
                        {
                            cmbMahalle.Items.Add("d");
                            cmbMahalle.Items.Add("e");
                            cmbMahalle.Items.Add("f");

                        }
                        else if (cmbIlce.SelectedIndex == 2)
                        {
                            cmbMahalle.Items.Add("g");
                            cmbMahalle.Items.Add("h");
                            cmbMahalle.Items.Add("k");

                        }
                    }
                    else { MessageBox.Show("tekrar dene"); }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            string sehirr=cmbSehir.Text;
            if (!StringHelpers.CheckIfEmpty(sehirr))

            {
                string sehirpwd = EncryptionHelper.Encrypt(sehirr);
                bool kayit = _SehirS.Kayit(sehirr);
                if (kayit)
                {
                    if (cmbSehir.SelectedIndex == 0)
                    {
                        cmbIlce.Items.Add("Avcılar");      
                        cmbIlce.Items.Add("Beşiktaş");
                        cmbIlce.Items.Add("Kadıköy");
                    }
                    else if (cmbSehir.SelectedIndex == 1)
                    {
                        cmbIlce.Items.Add("Etimesgut");
                        cmbIlce.Items.Add("Çankaya");
                        cmbIlce.Items.Add("Keçiören");

                    }
                }
                else { MessageBox.Show("tekrar dene"); }
            }
        }


            
    }
}