using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWPF
{
    internal class Yazar
    {
        public int Id { get; set; }
        public string NameLastname { get; set; }
        public DateTime DateTimebirthday { get; set; }
        public Kutuphane Kutuphane { get; set; }
        public Kitap Kitap { get; set; }
        public bool Onay { get; set; }
       
    }
}
