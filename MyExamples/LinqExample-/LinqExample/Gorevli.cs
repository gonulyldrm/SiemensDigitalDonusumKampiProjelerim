using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Gorevli
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yas { get; set; }
        public Gorevli(int id,string name,int yas) {
            Id= id;
            Name= name;
            Yas= yas;

        }
    }
}
