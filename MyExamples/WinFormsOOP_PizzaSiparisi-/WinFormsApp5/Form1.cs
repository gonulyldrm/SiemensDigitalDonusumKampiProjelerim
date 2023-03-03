
namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        Siparis siparis=new Siparis();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string boy = cmbPizzaboy.Text;
            string icecekk = cmbIcecek.Text;
            int adetboy = int.Parse(txtPizzaboyAdet.Text);
            int adeticecek = int.Parse(txtIcecekAdet.Text);
            SiparissAl siparisal = new SiparissAl();
            Pizzaboy pizzaboy = new Pizzaboy(boy, adetboy);
            Icecek icecek = new Icecek(icecekk, adeticecek);
            siparisal.Add(icecek);
            siparisal.Add(pizzaboy);
            //Extra extra = new Extra("mantar");
            //siparisal.Add(extra);

            lsbAdSoyad.Items.Add(txtAdSoyad.Text);
            lsbTelefon.Items.Add(txtTelefon.Text);
            lsbAdres.Items.Add(txtAdres.Text);
            lsbPizzaboyAdet.Items.Add(pizzaboy.pizzaboyy + " " + txtPizzaboyAdet.Text);
            lsbIcecekAdet.Items.Add(icecek.icecekName + " " + txtIcecekAdet.Text);
            lsbUcret.Items.Add(siparisal.ToplamUcret());

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox7.Items.Add(checkedListBox1.CheckedItems[i]);
               
            }

           // siparis.extra.Clear();
            //foreach (var item in checkedListBox1.SelectedItems)
            //{
             //   siparis.extra.Add((Extra)item);
            //}

            lsbUcret.Items.Add("**********");
            lsbAdSoyad.Items.Add("**********");
            lsbTelefon.Items.Add("**********");
            lsbAdres.Items.Add("**********");
            lsbPizzaboyAdet.Items.Add("**********");
            lsbIcecekAdet.Items.Add("**********");
            listBox7.Items.Add("**********");

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtPizzaboyAdet.Clear();
            txtIcecekAdet.Clear();

            lsbAdSoyad.Items.Clear();
            lsbTelefon.Items.Clear(); 
            lsbAdres.Items.Clear(); 
            lsbPizzaboyAdet.Items.Clear(); 
            lsbIcecekAdet.Items.Clear();
            lsbUcret.Items.Clear();
            listBox7.Items.Clear();

           
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            label16.Text = Convert.ToString(listBox7.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}