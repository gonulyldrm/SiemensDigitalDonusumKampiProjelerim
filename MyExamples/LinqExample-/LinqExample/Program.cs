using LinqExample;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    static void Main(string[] args)
    {
        List<Kutuphane> kutuphanes = new List<Kutuphane>()
        {
            new Kutuphane(5,"hhh",32,5,new DateTime(2000,8,7),new List<Kitap>() 
            {
                new Kitap(5,"fffffffffff",5,new Yazar(5,"","",new DateTime(1888,8,7)))
            }){},

            new Kutuphane(52,"mmm",36,5,new DateTime(2000,8,6),new List<Kitap>()
            {
                new Kitap(5,"fff",5,new Yazar(5,"ooo","ppp",new DateTime(1888,2,7)))
            }){},

        };
        List<Gorevli> gorevIi = new List<Gorevli>()
        {
           new Gorevli(5,"fff",89),
           new Gorevli(6,"ccc",55),
        };



        //id 4 den buyuk kütüphaneler
        var q = from x in kutuphanes
        where x.Id > 2
                select x;
        foreach (var item in q)
        {
            Console.WriteLine(item.Name);
        }
        //kutuphane adı ali olan kutuphaneler
        var q2 = from x in kutuphanes
                 where x.Name=="ali" 
                 select x;

      //kitapları Gurupla
        var q3 = from x in kutuphanes
        group x by x.Kitaps;

        // acılısına 25 yıldan az olan kutuphaneler gun olarak almak daha ıyı 
        var q4 = from x in kutuphanes
                 where x.AcılısTarihi.Year - DateTime.Now.Year < 25
                 select x;

        //ilk harfi k olan kutuphaneler
        var q5 = from x in kutuphanes
                 where x.Name.Substring(0, 1).ToUpper() == "k"
                 select x;

        var q6 = kutuphanes.Where(x => x.Name[0] == 'm');
        
        //koltuk sayısı 5 e bölündugunde masa sayısını verıyorsa yazdır --- her masaya 5 koltuk
        var q7=from x in kutuphanes
               where x.Koltuksayisi/5==x.Masasayisi
               select new {x.Name,x.Masasayisi };

        //yazıyı buyuk harf kucuk harf olarak yazdır
        var q8=from x in kutuphanes
               select new {buyut=x.Name.ToUpper(),kucult=x.Name.ToLower()};

        //orderby=listele kutuphane isimlerini listele
        var q9 = from x in kutuphanes
                orderby x.Name
                 select x.Name;

        var q10 = from x in kutuphanes
                  from y in gorevIi
                  orderby y.Name, x.Name
                  select x;
                

        // let sorgu içinde degişken tanımlamaya yarar
        var q11= from x in kutuphanes
                 let degisken=x.Name.ToLower()
                 where x.Name.StartsWith("k")
                 orderby x.Name
                 select x.Name;

        using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Z004PTMH\source\repos\LinqExample\LinqExample\Dosya.txt", true))
            dosya.WriteLine(q);

    }


}