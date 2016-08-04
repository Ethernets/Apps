namespace Apps2
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Insert Author, please");

            string name = Console.ReadLine();

            Console.WriteLine(Environment.NewLine + "Insert Title, please");

            string title = Console.ReadLine();

            Console.WriteLine("\nInsert Content, please");

            string content = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Beep();

            Book book = new Book(name, title, content);

            book.Show();

            Console.ReadKey();
        }
    }
}
