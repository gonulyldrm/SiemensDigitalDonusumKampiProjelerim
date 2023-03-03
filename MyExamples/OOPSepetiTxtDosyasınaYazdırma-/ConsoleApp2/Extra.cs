using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    partial class Extra : Product
    {
        public enum Extras
        {
            borek,
            kek,
            pasta

        }
        public Extras extrasonuc { get; set; }

        public Extra() { }

        public Extra(int extra) {


            Extras a = new Extras();
            switch (extra)
            {
                case 1:
                    a = Extras.borek;
                    this.Price = 5;
                    break;

                case 2:

                    a = Extras.kek;
                    this.Price = 6;
                    break;

                case 3:
                    a = Extras.pasta;
                    this.Price = 7;
                    break;
        }
    }


    }
        
}
