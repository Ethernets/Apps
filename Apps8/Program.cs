namespace Apps8
{
    using System;

    public class Program
   {
       public static void Main(string[] args)
        {
            DocumentWorker docWorker = null;

            Console.WriteLine("Введите ключ доступа");

            string isKey = Console.ReadLine();

            switch (isKey)
            {
                case "pro5632":
                    docWorker = new ProDocumentWorker();
                    Console.WriteLine("Pro version is available");
                    break;
                case "ex234521":
                    docWorker = new ExpertDocumentWorker();
                    Console.WriteLine("Expert version is available");
                    break;
                default:
                    docWorker = new DocumentWorker();
                    Console.WriteLine("Free version is available");
                    break;
            }

            docWorker.OpenDocument();

            docWorker.EditDocument();

            docWorker.SaveDocument();

            Console.ReadKey();
        }
    }
}
