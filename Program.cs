using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Digite um valor em Metros para converter para KM e CM:");

            string metros = Console.ReadLine();
            double cmMetro = Convert.ToDouble(metros) * 100;
            double kmMetro = Convert.ToDouble(metros) / 1000;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nEquivalência:");

            Console.WriteLine($"{cmMetro} cm \n{metros} m \n{kmMetro} km");

            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
