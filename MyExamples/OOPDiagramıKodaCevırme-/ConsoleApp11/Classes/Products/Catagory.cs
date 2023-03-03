using ConsoleApp11.Classes.Product.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp11.Classes.Products;
    internal class Catagory
    {
        public Catagory() {
            
        }
        
        public Catagory(string name, int id, Department department)
        {
            Name = name;
            Department = department;
            ID = id;
        }


        public string Name { get; set; }
        public Department Department { get; set; }
        public int ID { get; set; }
        public virtual int Getid() { return ID; }
        public virtual string Getname() { return Name; }
        public virtual Department Getdepartment() { return Department; }


        public bool Kontrol(string catagoriyy)
        {
            bool result = new bool();
            if (catagoriyy == Getname())
            {
                result = true;
            }
            return result;
        }
}
