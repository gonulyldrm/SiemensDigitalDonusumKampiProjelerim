using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWPF
{
    internal class Kitap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Baski { get; set; }
        

        public Kitap(int id, string name, int baski)
        {

            Id = id;
            Name = name;
            Baski = baski;
           


        }



    }
}
