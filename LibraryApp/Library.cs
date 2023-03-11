using System;

namespace LibApp {
    class Library {
        public Book[] books;
        public Library(Book[] books) {
            this.books = books;
        }
        public void ShowAllBooks() {
            for (int i = 0; i< books.Length; i++) {
                Book book = books[i];
                Console.WriteLine("------------------------------");
                Console.WriteLine("Title: "+book.title);
                Console.WriteLine("Author: "+book.author);
                Console.WriteLine("Pages: "+book.pages);
                Console.WriteLine("Availible: "+book.availible);
                Console.WriteLine("ID: "+book.id);
                Console.WriteLine("------------------------------\n");
            }
            
        }
        public Book GetBookByID(int id)
        {
            for (int i =0; i< books.Length; i++)
            {
                if (books[i].id == id)
                {
                    return books[i];
                }
            }
            return null;
        }
        public void CheckoutBook() {
            Console.Write("Enter a book ID: ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
                #pragma warning disable CS8600
                Book bk = GetBookByID(id);
                #pragma warning restore CS8600
                if (bk != null)
                {
                    App.user.AddBook(bk);
                    Console.WriteLine("Book added!\n");
                }
                else
                {
                    Console.WriteLine("Could not find book!\n");
                }
            } catch (FormatException) {
                Console.WriteLine("Please enter a valid ID in the correct format!\n");
            }

            
        }
    }
}