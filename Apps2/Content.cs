namespace Apps2
{
    using System;

   public class Content
    {
        private string source;

        public Content(string val)
        {
            this.source = val;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Content <{0}>", this.source);
        }
    }
}
