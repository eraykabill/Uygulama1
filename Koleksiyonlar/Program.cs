using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] İsimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(İsimler[0]);
            //Console.WriteLine(İsimler[1]);
            //Console.WriteLine(İsimler[2]);
            //Console.WriteLine(İsimler[3]);

            //İsimler = new string[5];
            //İsimler[4] = "İlker";
            //Console.WriteLine(İsimler[4]);
            //Console.WriteLine(İsimler[0]);
            //Console.ReadLine();

            List<string> İsimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(İsimler2[0]);
            Console.WriteLine(İsimler2[1]);
            Console.WriteLine(İsimler2[2]);
            Console.WriteLine(İsimler2[3]);
            İsimler2.Add("İlker");
            Console.WriteLine(İsimler2[4]);
            Console.WriteLine(İsimler2[0]);

            Console.ReadLine();
        }
    }
}
