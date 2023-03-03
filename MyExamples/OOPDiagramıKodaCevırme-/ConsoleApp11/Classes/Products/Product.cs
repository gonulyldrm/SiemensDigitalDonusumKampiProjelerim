using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Products
{
    internal class Product : Sales
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int ID { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public Catagory Catagory { get; set; }

        public Product() { }
        public Product(string name, string color,
            int iD, int size,
            int weight, Catagory catagory)
        {
            Name = name;
            Color = color;
            ID = iD;
            Size = size;
            Weight = weight;
            Catagory = catagory;
        }


        public virtual int GetId() { return ID; }
        public virtual string Getname() { return Name; }
        public virtual int GetSize() { return Size; }
        public virtual int GetWeight() { return Weight; }
        public virtual Catagory GetCatagory() { return Catagory; }
    }
}
