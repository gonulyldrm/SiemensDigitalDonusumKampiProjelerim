using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum BreadType
    {
        Beyaz = 1,
        Kepek = 2,
        Bugday = 3,
        Odun = 4,
        AltinEkmek = 5
    }

    public enum Gramaj
    {
        Yuz = 100,
        YuzYirmiBes = 125,
        IkiYuz = 200
    }

    //public static class Price
    //{
    //    public const double Bir = 1.0;
    //    public const double Iki = 2.0;
    //    public const double BirBucuk = 1.5;
    //}
    class Bread : Product
    {
        public BreadType Type { get; set; }
        public Gramaj Gram { get; set; }
        public string Uretici { get; set; }


        public override double SetKdv()
        {
            return this.Price * 1.01; ;
        }
        public Bread() { }

        public Bread(
           BreadType type)
        {

            switch (type)
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    this.Price = 2.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 2.0;
                    this.Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = 1.5;
                    this.Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }

        public Bread(
            double price,
            BreadType type)
        {
            double _price = 0;
            if (price > 0)
            {
                _price = price;
            }
            if (_price <= 0)
            {
                throw new Exception("Ekmek ücreti sıfır ya da sıfırdan küçük olamaz.");
            }
            switch (type)
            {
                case BreadType.Beyaz:
                    this.Price = _price;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = _price;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    this.Price = _price;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = _price;
                    this.Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = _price;
                    this.Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }
    }
    /// <summary>
    /// Ben custom bir ucret belirleyerek X tipindeki ekmegi satiyorum.
    /// </summary>
    /// <param name="type"></param>


}
