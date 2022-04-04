using ConsoleApp3.MODELS;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usd = new USD(300);
            AZN azn1 = new AZN(340);


            AZN azn = usd;
            USD usd1 = azn1;

            Console.WriteLine(usd1.Amount);
            Console.WriteLine(azn.Amount);

        }
    }
}
