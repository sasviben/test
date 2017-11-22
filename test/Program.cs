﻿using System;
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
            string unos = Console.ReadLine();
            try
            {
                double broj = double.Parse(unos);
                Console.WriteLine(KvadratniKorijen(broj));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
        
        public static double KvadratniKorijen(double broj)
        {
            return Math.Sqrt(broj);
        }
    }
}
