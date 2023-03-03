using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Store
{
    internal class Store : Sales
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int ID { get; set; }
        public int Telephone { get; set; }
        public City City { get; set; }
      
        public Store() { }
        public Store(string name, string adress, int iD ,int telephone,City city)
        {
            Name = name;
            Adress = adress;
            ID = iD;
            Telephone = telephone;
            City = city;
        }

        public virtual string GetAdress() { return Adress; }
        public virtual int GetId() { return ID; }
        public virtual string GetName() { return Name; }
        public virtual int GetTelephone() { return Telephone; }
        public virtual City GetCity() { return City; }
     
    }
}
