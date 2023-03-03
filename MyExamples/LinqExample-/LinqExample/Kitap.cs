using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Kitap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Baski { get; set; }
        public Yazar Yazar { get; set; }    

        public Kitap(int id, string name,int baski,Yazar yazar) {
            
            Id=id;
            Name = name;
            Baski=baski;
            Yazar=yazar;
            
        
        }
  


    }
}
