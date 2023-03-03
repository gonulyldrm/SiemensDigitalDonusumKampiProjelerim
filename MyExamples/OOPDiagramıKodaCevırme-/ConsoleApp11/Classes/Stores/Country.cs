using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Store
{
    internal class Country
    {
        public string Name { get; set; }
        public string Populatıon { get; set; }
        public int ID { get; set; }

        public Country() { }
        public Country(string name, string populatıon, int iD)
        {
            Name = name;
            Populatıon = populatıon;
            ID = iD;
        }

        public virtual int GetID() { return ID; }
        public virtual string GetName() { return Name;}
        public virtual string Getpopulat() { return Populatıon; }

    }
}
