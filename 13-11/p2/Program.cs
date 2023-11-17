namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Book book=new Book("Harry Potter", "The Goblet of Fire", "J. K. Rowling", 1000.32);
            Book book1 = new Book("Attack On Titan", "Season1", "Hajime Isayam", 1500.45);
            book.display();  
            book1.display();
        }
        class Book {
            string? BookName;
            string? Title;
            string? Author;
            double Price;
            public Book(string? BookName, string? Title, string? Author, double Price)
            {
                this.BookName = BookName;
                this.Title = Title;
                this.Author = Author;
                this.Price = Price;
            }
            public void display()
            {
                Console.WriteLine("BookName     :"+BookName);
                Console.WriteLine("Book Title   :"+Title);
                Console.WriteLine("Author       :"+Author);
            }
        }

    }
}