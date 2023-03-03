using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Pizzaboy:Siparis
    {
        public int ID { get; set; }
        public string pizzaboyy { get; set; }
        public enum Pizzaboys
        {
            orta,
            buyuk,
            kucuk

        }
        public Pizzaboy(string pizzaboy,int adet)
        {

            Pizzaboys boy = new Pizzaboys();

            switch (pizzaboy)
            {

                case "orta":
                    boy = Pizzaboys.orta;
                    this.ID = (int)Pizzaboys.orta;
                    this.ucret = 5*adet;
                    this.pizzaboyy = "orta";
                    break;
                case "buyuk":
                    boy = Pizzaboys.buyuk;
                    this.ID = (int)Pizzaboys.buyuk;
                    this.ucret = 6*adet;
                    this.pizzaboyy = "buyuk";
                    break;
                case "kucuk":
                    boy = Pizzaboys.kucuk;
                    this.ID = (int)Pizzaboys.kucuk;
                    this.ucret = 4 * adet;
                    this.pizzaboyy = "kucuk";
                    break;
                default:
                    break;

            }




        }

    }
}
