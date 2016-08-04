namespace Apps8
{
    using System;

    public class ExpertDocumentWorker : DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }

    }
}
