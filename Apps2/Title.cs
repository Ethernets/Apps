namespace Apps2
{
    using System;

    public class Title
    {
        private string name;

        public Title(string val)
        {
            this.name = val;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Title <{0}>", this.name);
        }
    }
}
