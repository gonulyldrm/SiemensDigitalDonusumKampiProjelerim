
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Kutuphane
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Koltuksayisi { get; set; }
        public int Masasayisi { get; set; } 
        public DateTime AcılısTarihi { get; set; }
        public List<Kitap> Kitaps { get; set; }
   
        public Kutuphane(int id, string name, int koltuksayisi, int masasayisi, DateTime acılısTarihi, List<Kitap> kitaps)
        {
            Id = id;
            Name = name;
            Koltuksayisi = koltuksayisi;
            Masasayisi = masasayisi;
            AcılısTarihi = acılısTarihi;
            Kitaps = kitaps;
        }
        
    }

}
