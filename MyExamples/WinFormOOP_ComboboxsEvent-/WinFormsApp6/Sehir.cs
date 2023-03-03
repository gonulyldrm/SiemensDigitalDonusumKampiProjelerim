using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    internal class Sehir
    {
        public string Ilce { get; set; }
        public string Sehirismi { get; set; }
        public string Mahalle { get; set; } 
        
        
        
        public Sehir() { }
        public Sehir(string Sehirismi, string Ilce, string Mahalle )
        {

            this.Ilce = Ilce;
            this.Sehirismi = Sehirismi;
            this.Mahalle = Mahalle;  
        }
        public bool Kayit(string Sehir) { return true; }
        public bool Kayit2(string Ilce) { return true; }
    }
}
