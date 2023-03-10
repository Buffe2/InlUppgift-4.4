using System;

namespace Inluppgift_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet"); 

            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                {
                    Console.Write("Välj ett tal: ");
                    int tal1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Välj ett till tal: ");
                    int tal2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(tal1 + " - " + tal2 + " = " + (tal1 - tal2));

                    break;
                }

                case "2":
                {
                    Console.Write("Välj ett tal: ");
                    int tal1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Välj ett till tal: ");
                    int tal2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(tal1 + " / " + tal2 + " = " + (tal1 / tal2));

                    break;
                }
                case "3":
                {
                    break;
                }
            }
        }
    }
}