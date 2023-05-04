namespace Richter.DesignPattern.NestedFactory
{
    public sealed class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

        private Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

        //Inner or Nested Factory
        public static class Factory
        {
            public static Book GetBook(string title, string author)
            {
                //I do not encourage the use of exceptions for this type of validation.
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                    throw new ArgumentNullException();

                var newTitle = title.Trim();
                var newAuthor = author.Trim();

                return new Book(newTitle, newAuthor);
            }
        }
    }
}
