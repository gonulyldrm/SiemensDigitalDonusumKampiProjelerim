using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWPF
{ 
    internal class Kutuphane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Koltuksayisi { get; set; }
        public int Masasayisi { get; set; }
       

        public Kutuphane(int id, string name, int koltuksayisi, int masasayisi)
        {
            Id = id;
            Name = name;
            Koltuksayisi = koltuksayisi;
            Masasayisi = masasayisi;
            
        }

    }

}
