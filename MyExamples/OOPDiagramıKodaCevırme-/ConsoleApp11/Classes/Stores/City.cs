using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Store
{
    internal class City
    {
        public string Name { get; set; }
        public string Populatıon { get; set; }
        public int ID { get; set; }
        public Country Countrys { get; set; }

        public City() { }
        public City(string name, string populatıon,
            int iD, Country countrys)
        {
            Name = name;
            Populatıon = populatıon;
            ID = iD;
            Countrys = countrys;
        }
        public virtual int GetId() { return ID; }
        public virtual Country GetCountry() { return Countrys; }
        public virtual string Getname() { return Name; }
        public virtual string Getpopulat() { return Populatıon; }

        //public string CCity()
        //{

        //    if (Getname() == "kahramanmaras")
        //    { 
        //        Countrys.Name= "türkiye";
        //        return Countrys.Name;
        //    }
        //    return Countrys.Name;

        //}
    }
}
