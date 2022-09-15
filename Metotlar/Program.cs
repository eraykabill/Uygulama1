using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();           
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Yeşil Armut";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 12;
            urun3.Aciklama = "Yeşil Armut";
            urun3.StokAdedi = 10;

            Urun urun4 = new Urun();
            urun4.Adi = "Elma";
            urun4.Fiyati = 12;
            urun4.Aciklama = "Yeşil Elma";
            urun4.StokAdedi = 9;

            Urun urun5 = new Urun();
            urun5.Adi = "Karpuz";
            urun5.Fiyati = 12;
            urun5.Aciklama = "Diyarbakır Karpuzu";
            urun5.StokAdedi = 8;

            Urun[] Urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("------Metotlar--------");
            //İntance-Örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(urun3);
            sepetManager.Ekle2(urun4);
            sepetManager.Ekle2(urun5);


            Console.ReadLine();

        }
    }
}
