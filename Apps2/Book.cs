namespace Apps2
{
    using System;

   public class Book
    {
        private Author author;

        private Title title;

        private Content content;

        public Book(string name, string header, string source)
        {
            this.author = new Author(name);

            this.title = new Title(header);

            this.content = new Content(source);
        }

        public void Show()
        {
            this.author.Show();

            this.title.Show();

            this.content.Show();
        }
    }
}
