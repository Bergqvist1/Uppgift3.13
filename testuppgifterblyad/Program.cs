using System;
namespace Uppgift_3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");

            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får delta i tävlignen");
            }
            if (ålder < 16)
            {
                Console.WriteLine("Du får inte delta i tävlignen för att du är för ung");
            }
            if (ålder > 19)
            {
                Console.WriteLine("Du är för gammal för att få delta i tävlingen");
            }
        }
    }
}
