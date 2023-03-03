using ConsoleApp2;
using System.Threading;
using static ConsoleApp2.Extra;

class Program
{
    static void Main(string[] args)
    {

        Basket basket = new Basket();

        Console.WriteLine(" bir kepek ve bir altın ekmek aldınız extra sipariş secınız: [1]borek [2]kek [3]pasta ");
        int secim = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("kaç para ödediniz: ");
        double paraa = Convert.ToDouble(Console.ReadLine());
        
        Bread ekmek = new Bread(BreadType.Kepek);
        Bread ekmek1 = new Bread(BreadType.AltinEkmek);
        Extra extra1 = new Extra(secim);
       
        basket.Add(ekmek);
        basket.Add(ekmek1);
        basket.Add(extra1);


        Console.WriteLine("Toplam fiyat(KDV hariç): " + basket.TotalPrice());
        Console.WriteLine("Toplam fiyat(KDV dahil): " + basket.TotalPriceWithKDV());
        Console.WriteLine("Sipariş KDV toplamı: " + (basket.TotalPriceWithKDV() - basket.TotalPrice()));
        Console.WriteLine("Para ustu: " + (basket.Paraustu(paraa)));


        using (System.IO.StreamWriter dosya=new System.IO.StreamWriter(@"C:\Users\Z004PTMH\source\repos\ConsoleApp2\ConsoleApp2\Dosya.txt",true))
        dosya.WriteLine( basket.FisYazdir(paraa));
 

    }

}
