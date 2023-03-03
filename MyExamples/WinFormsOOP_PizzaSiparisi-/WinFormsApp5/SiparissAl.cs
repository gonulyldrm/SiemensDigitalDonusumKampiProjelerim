using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class SiparissAl
    {
        private List<Siparis> siparisS = new List<Siparis>();
        public void Add(Siparis siparis)
        {
            if (siparis != null)
                siparisS.Add(siparis);
        }

        public double ToplamUcret()
        {
            double toplamucret = 10;
            foreach (Siparis s in siparisS)
            {
                toplamucret += s.ucret;
            }
            return toplamucret;
        }
        public List<Siparis> GetSipariss()
        {
            return siparisS;
        }


    }
}
