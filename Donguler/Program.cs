using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java","Python","C++" };


            for (int i = 0; i < kurslar.Length; i++) // Length:Eleman Sayısı
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) // Dizileri dolaşmak için foreach kullanılır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu-footer");
            Console.ReadLine();
        }
    }
}
