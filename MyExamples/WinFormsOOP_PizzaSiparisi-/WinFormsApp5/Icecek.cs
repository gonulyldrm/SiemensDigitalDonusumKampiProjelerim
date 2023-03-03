using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Icecek:Siparis
    {
        public int IDD{get; set;}
        public string icecekName { get; set;}
        public enum Icecekler{
        
            kola,
            fanta
        
        }
        public Icecek() { }
        public Icecek(string icecek,int adett)
        {

            Icecekler icece = new Icecekler();

            switch (icecek)
            {

                case "kola":
                    icece = Icecekler.kola;
                    this.IDD = (int)Icecekler.kola;
                    this.ucret = 3*adett;
                    this.icecekName = "kola"; 
                    break;
                case "fanta":
                    icece = Icecekler.fanta;
                    this.IDD = (int)Icecekler.fanta;
                    this.ucret = 4 * adett;
                    this.icecekName = "fanta";
                    break;
                
                default:
                    break;

            }




        }

    }
}
