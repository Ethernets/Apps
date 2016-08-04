namespace Apps7
{
    using System;

   public class Editor
    {
        HandlerBase handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            switch (format.ToLower())
            {
                case ".txt":
                    this.handler = new TXTHandler(fileName);
                    break;
                case ".doc":
                    this.handler = new DOCHandler(fileName);
                    break;
                case ".xml":
                    this.handler = new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("I can't handle that unknown format");
                    break;
            }
        }

        public void Open()
        {
            this.handler.Open();
        }

        public void Craete()
        {
            this.handler.Create();
        }

        public void Change()
        {
            this.handler.Change();
        }

        public void Save()
        {
            this.handler.Save();
        }
    }
}
