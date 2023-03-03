namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string yazi;
        public string kaydet()
        {
            string ad = textBox1.Text;
            string sayfa = textBox2.Text;
            string katagori = comboBox1.Text;
            
            Katagori katagoriId = new Katagori(katagori);


            return "kitap adı:"+  ad +"  kitap sayfası :" +sayfa +"  kitap katagorisi: "+ katagori+" Kitap katagori İD: "+katagoriId.ID;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Z004PTMH\source\repos\WinFormsApp4\WinFormsApp4\Dosya.txt", true))
                    dosya.WriteLine(kaydet());
                    textBox1.Clear();
                    textBox2.Clear();
                     break;

                case CheckState.Unchecked:
                    MessageBox.Show("lutfen onaylayın");
                    break;

                case CheckState.Indeterminate:
                    MessageBox.Show("lutfen onaylayın");

                    break;
            }


            //using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Z004PTMH\source\repos\WinFormsApp4\WinFormsApp4\Dosya.txt", true))
            //
            //dosya.WriteLine(kaydet());

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = yazi;
        }

        private void onayla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }
    }
}