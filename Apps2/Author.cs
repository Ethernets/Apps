namespace Apps2
{
    using System;

   public class Author
    {
        private string authorVal;

        public Author(string val)
        {
            this.authorVal = val;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Author <{0}>", this.authorVal);
        }
    }
}
