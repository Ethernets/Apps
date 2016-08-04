namespace Apps7
{
    using System;

   abstract class HandlerBase
    {
        protected string fileName;

        public HandlerBase(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(this.fileName + " opened");
        }

        public void Create()
        {
            Console.WriteLine(this.fileName + " created");
        }

        public abstract void Change();

        public void Save()
        {
            Console.WriteLine(this.fileName + " edited");
        }
    }

    class XMLHandler : HandlerBase
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Change()
        {
            Console.WriteLine(this.fileName + " changed an .xml file");
        }
    }

    class TXTHandler : HandlerBase
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Change()
        {
            Console.WriteLine(this.fileName + " changed a .txt file");
        }
    }

  class DOCHandler : HandlerBase
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Change()
        {
            Console.WriteLine(this.fileName + " changed a .doc file");
        }
}
}
