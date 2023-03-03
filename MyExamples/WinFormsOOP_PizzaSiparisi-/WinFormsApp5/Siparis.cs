using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Siparis
    {
        public int id { get; set; }
        public string adsoyad { get; set; }
        public int telefon { get; set; }   
        public Pizzaboy pizzaboy { get; set; }
        public Icecek icecek { get; set; }
        public List<Extra> extra { get; set; }
        public string adres { get; set; }
        public double ucret { get; set; }
        public Siparis() { }
        public Siparis(int id, string adsoyad, int telefon,Pizzaboy pizzaboy,Icecek icecek,Extra extra, string adres, double ucret)
        {
            this.id = id;
            this.adsoyad = adsoyad;
            this.telefon = telefon;
            this.pizzaboy = pizzaboy;
            this.icecek = icecek;
            this.extra = new List<Extra>();
            this.adres = adres;
            this.ucret = ucret;
        }
    }
}
