using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Product.Product
{
    internal class Department
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Department() { }
        public Department(string name, int iD)
        {
            Name = name;
            ID = iD;
        }
        
        public virtual int GetID() { return ID; }
        public virtual string GetName() { return Name; }
    }
}
