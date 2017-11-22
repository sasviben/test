using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poruka");
            Console.WriteLine("Message");
            Console.WriteLine("Werbung");

            Console.WriteLine("Upiši neki broj za koji želiš kvadratni korijen: ");
            string unos = Console.ReadLine();
            try
            {
                double broj = double.Parse(unos);
                double rezultat = KvadratniKorijen(broj);
                Console.WriteLine($"Kvadratni korijen od {broj} je {rezultat}");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        public static double KvadratniKorijen(double broj)
        {
            return Math.Sqrt(broj);
        }
    }
}
