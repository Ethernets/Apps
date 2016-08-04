namespace Apps7
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            Editor editor = new Editor();

            editor.ChooseDocument("mySuperFile.XML");

            editor.Open();

            editor.Change();

            editor.Save();

            Console.ReadKey();
        }
    }
}
