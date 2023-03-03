using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Extra:Siparis
    {
        public int IdD { get; set; }
        public string ExtraName { get; set; }
        public enum Extralar
        {
            mantar,
            peynir,
            sucuk,
            sebze
        }
        public Extra() { }
        public Extra(string extra)
        {
            Extralar extralar = new Extralar();
            switch (extra)
            {
                case "mantar":
                    extralar = Extralar.mantar;
                    this.IdD = (int)Extralar.mantar;
                    this.ucret = 3;
                    break;
                case "peynir":
                    extralar = Extralar.peynir;
                    this.IdD = (int)Extralar.peynir;
                    this.ucret = 4;
                    break;
                case "sebze":
                    extralar = Extralar.sebze;
                    this.IdD = (int)Extralar.sebze;
                    this.ucret = 5;
                    break;
                case "sucuk":
                    extralar = Extralar.sucuk;
                    this.IdD = (int)Extralar.sucuk;
                    this.ucret = 6;
                    break;
                default:
                    break;
            }
        }
    }
}
