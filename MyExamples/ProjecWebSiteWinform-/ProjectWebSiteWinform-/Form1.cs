using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectWebSiteWinform_
{
    

    public partial class Form1 : Form
    {
         List<Product> p_list = new List<Product>();
        private static string product_card_query = "//div[@class='col-xxl-2 col-xl-3 col-md-3 col-6']/a[1]";
        private const string BASE_URI = "https://www.osevio.com/urun/hediye";
        public Form1()
        {
            InitializeComponent();
            btnGetwebsiteProduct.Click += Button1_Click;
            btnAddDatabase.Click += Button2_Click;
            btnFileSave.Click += BtnFileSave_Click;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            Savefile();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveDatabase();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetProduct();
            dataGridView1.DataSource = p_list;
        }

        public void GetProduct()
        {
           

            HtmlWeb web = new HtmlWeb();
            List<Product> product_list = new List<Product>();
            int pageNumber = 50;
            while (true)
            {
                try
                {

                    var doc = web.Load(BASE_URI);

                    var products = doc.DocumentNode.SelectNodes(product_card_query);


                    foreach (var productDiv in products)
                    {
                        Product new_product = new Product();

                        var product_url_node = productDiv.SelectSingleNode("//a[@class='card reduced  mb-3']");
                        if (product_url_node != null)
                            new_product.ProductUri = BASE_URI + product_url_node.Attributes["href"].Value;

                        var product_image_node = productDiv.SelectSingleNode(".//figure/img");
                        string product_image_url = string.Empty;
                        if (product_image_node != null)
                            new_product.ProductImageUri = product_image_node.Attributes["src"].Value;

                        var title_node = productDiv.SelectSingleNode(".//div/p");
                        if (title_node != null)
                            new_product.ProductTitle = title_node.InnerText;

                        var price_node = productDiv.SelectSingleNode(".//div/ul/li[3]/div/span[1]");
                        if (price_node != null)
                            new_product.ProductPrice = price_node.InnerText;


                        product_list.Add(new_product);
                        

                    }
                    pageNumber++;
                    p_list = product_list;
                    
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    break;
                }
            }
        }
        public void SaveDatabase()
        {
            {
            HtmlWeb web = new HtmlWeb();
            List<Product> product_list = new List<Product>();
            int pageNumber = 50;
                while (true)
                {
                    try
                    {

                        var doc = web.Load(BASE_URI);

                        var products = doc.DocumentNode.SelectNodes(product_card_query);


                        foreach (var productDiv in products)
                        {
                            Product new_product = new Product();

                            var product_url_node = productDiv.SelectSingleNode("//a[@class='card reduced  mb-3']");
                            if (product_url_node != null)
                                new_product.ProductUri = BASE_URI + product_url_node.Attributes["href"].Value;

                            var product_image_node = productDiv.SelectSingleNode(".//figure/img");
                            string product_image_url = string.Empty;
                            if (product_image_node != null)
                                new_product.ProductImageUri = product_image_node.Attributes["src"].Value;

                            var title_node = productDiv.SelectSingleNode(".//div/p");
                            if (title_node != null)
                                new_product.ProductTitle = title_node.InnerText;

                            var price_node = productDiv.SelectSingleNode(".//div/ul/li[3]/div/span[1]");
                            if (price_node != null)
                                new_product.ProductPrice = price_node.InnerText;


                            string sql = "INSERT INTO Products VALUES('" + product_image_node.Attributes["src"].Value +
                                "','" + title_node.InnerText + "','" + price_node.InnerText + "','" + BASE_URI + product_url_node.Attributes["href"].Value + "')";
                            SqlConnection conn = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=OSevioWebsite;Integrated Security=SSPI");
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                        }
                        pageNumber++;


                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                        break;
                    }
                }
            }
        }
        public void Savefile()
        {


            HtmlWeb web = new HtmlWeb();
            List<Product> product_list = new List<Product>();
            int pageNumber = 50;
            while (true)
            {
                try
                {

                    var doc = web.Load(BASE_URI);

                    var products = doc.DocumentNode.SelectNodes(product_card_query);


                    foreach (var productDiv in products)
                    {
                        Product new_product = new Product();

                        var product_url_node = productDiv.SelectSingleNode("//a[@class='card reduced  mb-3']");
                        if (product_url_node != null)
                            new_product.ProductUri = BASE_URI + product_url_node.Attributes["href"].Value;

                        var product_image_node = productDiv.SelectSingleNode(".//figure/img");
                        string product_image_url = string.Empty;
                        if (product_image_node != null)
                            new_product.ProductImageUri = product_image_node.Attributes["src"].Value;

                        var title_node = productDiv.SelectSingleNode(".//div/p");
                        if (title_node != null)
                            new_product.ProductTitle = title_node.InnerText;

                        var price_node = productDiv.SelectSingleNode(".//div/ul/li[3]/div/span[1]");
                        if (price_node != null)
                            new_product.ProductPrice = price_node.InnerText;


                        string txt = new_product.ProductImageUri + "  " + new_product.ProductTitle + "  " +
                             new_product.ProductPrice + "  " + new_product.ProductUri;
                        using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Z004PTMH\source\repos\ProjecWebSiteWinform-\ProjectWebSiteWinform-\Dosya.txt", true))
                            dosya.WriteLine(txt.ToString());


                    }
                    pageNumber++;


                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    break;
                }
            }
        }
        public void FilterProduct()
        { 
            HtmlWeb web = new HtmlWeb();
            List<Product> product_list = new List<Product>();
            int pageNumber = 50;
            while (true)
            {
                try
                {

                    var doc = web.Load(BASE_URI);

                    var products = doc.DocumentNode.SelectNodes(product_card_query);


                    foreach (var productDiv in products)
                    {
                        Product new_product = new Product();

                        var product_url_node = productDiv.SelectSingleNode("//a[@class='card reduced  mb-3']");
                        if (product_url_node != null)
                            new_product.ProductUri = BASE_URI + product_url_node.Attributes["href"].Value;

                        var product_image_node = productDiv.SelectSingleNode(".//figure/img");
                        string product_image_url = string.Empty;
                        if (product_image_node != null)
                            new_product.ProductImageUri = product_image_node.Attributes["src"].Value;

                        var title_node = productDiv.SelectSingleNode(".//div/p");
                        if (title_node != null)
                            new_product.ProductTitle = title_node.InnerText;

                        var price_node = productDiv.SelectSingleNode(".//div/ul/li[3]/div/span[1]");
                        if (price_node != null)
                            new_product.ProductPrice = price_node.InnerText;

                        string k=price_node.InnerText;
                        int price=int.Parse(k); 
                        if (price>300)
                        {

                            product_list.Add(new_product);
                        }



                    }
                    pageNumber++;
                    p_list = product_list;

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    break;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked=true)
            {
                FilterProduct();
                dataGridView1.DataSource = p_list;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            string Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pictureBox1.ImageLocation= Text.ToString();
            
            
        }
    }
}
