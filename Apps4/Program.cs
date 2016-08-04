namespace Apps4
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            Converter converter = new Converter(24.15, 27.50, 32.02);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("What sum of EUR would you like to convert?");

            string eurToUah = Console.ReadLine();

            Console.WriteLine("\nAmount in UAH is {0} ", converter.FromEUR(Convert.ToDouble(eurToUah)));

            Console.BackgroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("\nWhat sum of UAH would you like to convert?");

            string uahToUsd = Console.ReadLine();

            converter.ToUSD(Convert.ToDouble(uahToUsd));

            Console.ReadKey();
        }
    }
}
