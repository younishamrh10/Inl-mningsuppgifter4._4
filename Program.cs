using System;

namespace Inlämningsuppgifter4._4
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine(" Välj ett av alternativen genom att välja siffran");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");
            string val = Console.ReadLine();

            if (val == "1")
            {
                Console.WriteLine("Skriv in ett tal");
                double tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Srkiv in ditt andra tal");
                double tal2 = int.Parse(Console.ReadLine());
                double resultat = tal1 - tal2;
                Console.WriteLine(resultat);
            }
            else if (val == "2")
            {
                Console.WriteLine("Skriv in ett tal");
                double tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Srkiv in ditt andra tal");
                double tal2 = int.Parse(Console.ReadLine());
                if (tal2 == 0)
                {
                    Console.WriteLine("Kan inte dividera med noll");
                }
                else
                {
                    double resultat = tal1 / tal2;
                    Console.WriteLine($"Resultatet av divisionen är: {resultat}");
                }
            }
            else if (val == "3")
            {
                Console.WriteLine("Avsluta programet.");

               

            }
            else
            {
                Console.WriteLine("Ogiltigt val. Vänligen ange 1, 2 eller 3.");
            }
        }
        
    }
}