namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("1st"));
            bookShelf.AppendBook(new Book("2nd"));
            bookShelf.AppendBook(new Book("3rd"));
            bookShelf.AppendBook(new Book("4th"));

            IIterator it = bookShelf.Iterator();
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                System.Console.WriteLine(book.GetName());
            }
        }
    }
}
