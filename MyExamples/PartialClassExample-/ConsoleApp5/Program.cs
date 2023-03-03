using ConsoleApp5;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Kullanici k= new Kullanici();
        k.Firstname = "gnl";
        k.Gunsayi =10;
        k.Email = "aaaaaaaaaaa@hotmail.com";
     
        
        Console.WriteLine(k.MaasHesapla(k.Gunsayi));
        Console.WriteLine(k.Maas);
    }

}
