using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExamplee
{
    internal class Product
    {
        public int ProductID { get; set; }
      
        public string ProductName { get; set; }  
        public int UnitsInStock { get; set; }
        public int UnitPrice { get; set; }
        public Product(int id,string name, int price, int productinstock) 
        {
            ProductID=id;
            ProductName = name; 
             UnitPrice = price;
            UnitsInStock= productinstock;
           

        }
        public Product()
        {

        }


    }
}
