using System.Threading;
using System.Timers;
using System.Xml;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Olusturma();

        Console.WriteLine("Kaç User Eklemek İstersiniz : ");
        int userSayi=Convert.ToInt32(Console.ReadLine());
        
        Ekle(userSayi);
        Okuma();

    }
    public static void Ekle(int usersayi)
    {
        for (int i = 0; i < usersayi; i++)
        {
            Console.WriteLine("id: ");
            string idd = Console.ReadLine();
            Console.WriteLine("ad: ");
            string add = Console.ReadLine();
            Console.WriteLine("soyad: ");
            string soyadd = Console.ReadLine();
            Console.WriteLine("Email: ");
            string emaill = Console.ReadLine();
            Console.WriteLine("Active");
            string activee = Console.ReadLine();

            XDocument xDoc = XDocument.Load(@"C:\Users\Z004PTMH\source\repos\ConsoleApp6\ConsoleApp6\bin\Debug\net7.0\dosya.xml");

            XElement rootElement = xDoc.Root;
            XElement newElement = new XElement("User");

            XElement id = new XElement("Id", idd);
            XElement ad = new XElement("Ad", add);
            XElement soyad = new XElement("Soyad", soyadd);
            XElement email = new XElement("Email", emaill);
            XElement active = new XElement("Active", activee);

            newElement.Add(id, ad, soyad, email, active);
            rootElement.Add(newElement);
            xDoc.Save(@"C:\Users\Z004PTMH\source\repos\ConsoleApp6\ConsoleApp6\bin\Debug\net7.0\dosya.xml");

        }
        
    }
    /// <summary>
    /// Xml dosyasına yeni User ve bilgilerini eklemek için kullanılır.
    /// </summary>
    public static void Okuma()
    {
        XDocument xDoc = XDocument.Load(@"C:\Users\Z004PTMH\source\repos\ConsoleApp6\ConsoleApp6\bin\Debug\net7.0\dosya.xml");
 
        XElement rootElement = xDoc.Root;
 
        String AD, Email, Soyad,Active, ID;
 
        foreach (XElement User in rootElement.Elements())
         {
            ID = User.Element("Id").Value;
            AD = User.Element("Ad").Value;
            Email = User.Element("Email").Value;
            Soyad = User.Element("Soyad").Value;
            Active = User.Element("Active").Value;

            Console.WriteLine("ID: " + ID + " AD: " + AD + " Email: " + Email + " Soyad: " + Soyad+" Active "+Active);
         }
    }
    /// <summary>
    /// Xml dosyasındaki User bilgilerini Console yazdırmak için kullanılır
    /// </summary>

    public static void Olusturma()
    {
        string xmlDosyasi = @"dosya.xml";
        XmlWriter xmlYazici = XmlWriter.Create(xmlDosyasi);
        xmlYazici.WriteStartDocument();

        xmlYazici.WriteStartElement("Users");
        xmlYazici.WriteStartElement("User");

        xmlYazici.WriteElementString("Id", "1");
        xmlYazici.WriteElementString("Ad", "ali");
        xmlYazici.WriteElementString("Soyad", "gundogdu");
        xmlYazici.WriteElementString("Email", "kkkkkkk@aaaaaaaaaaaa");
        xmlYazici.WriteElementString("Active", "true");
        xmlYazici.WriteEndElement();

        xmlYazici.WriteEndDocument();
        xmlYazici.Close();
    }
    ///// Xml dosyası oluşurma ve bir User ekleme

}
