using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen İsim Giriniz,-Baş harf büyük-");
            string kelime = Console.ReadLine();
            int sayi = kelime.Length;

            for (int i = 0, m = 1; i < 30; i++)
                for (int l = 0; l < new[] { 5, 6, 7, 6, 8, 10, 3, 10, 4, 13, 1, 13, 1, 87, 1, 27, 4, 23, 7, 20, 11, 16, 16, 11, 20, 7, 24, 3, 27, 1 }[i]; l++, m++)
                    Console.Write((i % 2 > 0 ? kelime [m % sayi] : ' ') + (m % 29 > 0 ? "" : "\n"));
            Console.ReadKey();
        }
    }
}
