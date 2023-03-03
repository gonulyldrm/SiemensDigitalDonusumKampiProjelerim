using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Yazar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Lastname{ get; set; }
        public DateTime DateTimebirthday { get; set; }

        public Yazar(int id,string name,string lastname,DateTime time) 
        
        {
            Id= id;
            Name= name;
            Lastname= lastname;
            DateTimebirthday =time;
        }
        
    }
}
