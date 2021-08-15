using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalnoStevilo, zacasnoStevilo, ostanek, obrnjenoStevilo = 0;

            Console.Write("Vnesi število: ");
            originalnoStevilo = int.Parse(Console.ReadLine());

            zacasnoStevilo = originalnoStevilo;

            Console.WriteLine("\n========== Logični izračun ==========");
            Console.WriteLine("========= Pred While Loop-om ========\n");
            Console.WriteLine("Originalno število = " + originalnoStevilo);
            Console.WriteLine("Začasno število = " + zacasnoStevilo);
            Console.WriteLine("Obrnjeno število = " + obrnjenoStevilo);
            Console.WriteLine("\n");

            Console.WriteLine("======== Začetek While Loop-a =======\n");

            while (originalnoStevilo > 0)
            {
                ostanek = originalnoStevilo % 10;
                Console.WriteLine("Ostanek = " + ostanek);
                obrnjenoStevilo = obrnjenoStevilo * 10 + ostanek;
                Console.WriteLine("Obrnjeno število = " + obrnjenoStevilo);
                originalnoStevilo /= 10;
                Console.WriteLine("Originalno število = " + originalnoStevilo);
                Console.WriteLine("Zaključeno\n\n");
            }

            Console.WriteLine("======== Konec While Loop-a =========");
            Console.WriteLine("======== Koda po While Loop-u =======\n");
            Console.WriteLine("===== Kakšno je obrnjeno število ====\n");
            Console.WriteLine("Originalno število: {0}", zacasnoStevilo);
            Console.WriteLine("Obrnjeno število: {0}", obrnjenoStevilo);
            Console.WriteLine("\n=====================================\n");

            Console.WriteLine("=====================================");
            if (zacasnoStevilo == obrnjenoStevilo)
            {
                Console.WriteLine("Vnešeno število JE palindromsko število!");
            } else
            {
                Console.WriteLine("Vnešeno število NI palindromsko število");
            }
            Console.WriteLine("=====================================");
            Console.ReadLine();
        }
    }
}
