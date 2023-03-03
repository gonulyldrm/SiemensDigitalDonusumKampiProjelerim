using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    partial class Kullanici
    {
        public double MaasHesapla(double gunSayisi)
        {
            double maas=0; 

            if (gunSayisi > 0)
            {
                maas=gunSayisi * 1000;
                this.Maas=maas;
                return maas;
            }
            return maas;    

        }


    }
}
