using System;

namespace LibraryManagementSystem
{
   
    struct Book
    {
        public string ISBN;
        public string Title;
        public string Author;
        public double Price;

       
        public Book(string isbn, string title, string author, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
        }

       
        public void DisplayBook()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {Author}, Price: {Price:C}");
        }
    }

    
    class Library
    {
        private Book[] books; 
        private int bookCount; 
        
        public Library(int capacity)
        {
            books = new Book[capacity];
            bookCount = 0;
        }

        
        public void AddBook(Book book)
        {
            if (bookCount < books.Length)
            {
                books[bookCount] = book;
                bookCount++;
                Console.WriteLine("Book added successfully.");
            }
            else
            {
                Console.WriteLine("Library is full. Cannot add more books.");
            }
        }

        
        public void DisplayAllBooks()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("Books in the Library:");
                for (int i = 0; i < bookCount; i++)
                {
                    books[i].DisplayBook();
                }
            }
        }

        
        public void SearchBookByISBN(string isbn)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    Console.WriteLine("Book found:");
                    books[i].DisplayBook();
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library(5); 

            while (true)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Search Book by ISBN");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        double price = double.Parse(Console.ReadLine());

                        Book newBook = new Book(isbn, title, author, price);
                        library.AddBook(newBook);
                        break;

                    case 2:
                        
                        library.DisplayAllBooks();
                        break;

                    case 3:
                        
                        Console.Write("Enter ISBN to search: ");
                        string searchISBN = Console.ReadLine();
                        library.SearchBookByISBN(searchISBN);
                        break;

                    case 4:
                        
                        Console.WriteLine("Exiting the Library Management System. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
