using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Basket
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            if (product != null)
                products.Add(product);

            ////v1

            //if (product.GetType() == typeof(Bread))
            //    Console.WriteLine("Bread");

            ////v2

            //if(product is Bread)
            //    Bread br = (Bread)product;

            //v3
            //if(product is Bread)
            //    Bread bread = product as Bread;
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        public double Paraustu(double para)
        {
             
            return para - TotalPriceWithKDV();
        }
        /// <summary>
        /// Consolden İstenen para mıktarından Toplam tutarı çıkarır.
        /// </summary>
        /// <returns></returns>

        public double TotalPriceWithKDV()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.SetKdv();
            }
            return totalPrice;
        }
        public string FisYazdir(double paraa)
        {
            return "Toplam fiyat(KDV hariç): " + TotalPrice()
            + "  Toplam fiyat(KDV dahil): " + TotalPriceWithKDV() +
            "  Sipariş KDV toplamı: " + (TotalPriceWithKDV() - TotalPrice())+
           "  para ustu: " +Paraustu(paraa);
        }
        /// <summary>
        /// Fişe yansıyan degerlerı dosya.txt ye yazdırmak için kullanılır.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return products;
        }

    }
}
