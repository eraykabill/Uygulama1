using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Kabil";
            musteri1.KrediNotu = 500;

           

            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.Adi = "Gönül";
            musteri2.Soyadi = "Kabil";
            musteri2.KrediNotu = 600;

            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 789;
            musteri3.Adi = "Eren";
            musteri3.Soyadi = "Kabil";
            musteri3.KrediNotu = 700;

            
           
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            foreach (var musteri in musteriler) 
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.KrediNotu);
                Console.WriteLine("------------------");
            }

            
            Console.ReadLine();
        }
    }
}
