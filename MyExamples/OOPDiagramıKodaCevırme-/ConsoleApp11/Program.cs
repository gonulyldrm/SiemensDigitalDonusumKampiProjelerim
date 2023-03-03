using ConsoleApp11.Classes.Product.Product;
using ConsoleApp11.Classes.Store;
using System.Drawing;
using ConsoleApp11.Help;
namespace ConsoleApp11.Classes.Products;
class Program
{
    public static void Main(string[] args)
    {
        Catagory catagory =new Catagory();

        catagory.Name = "aaa";
        catagory.ID = 5;
        
        Console.WriteLine(catagory.Getid());
        bool sonuc=catagory.Kontrol("aaa");
        Console.WriteLine(sonuc);

    }
}