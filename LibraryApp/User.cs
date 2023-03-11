using System;
using System.Collections.Generic;
namespace LibApp {
    class User {
        private List<Book> cart = new List<Book>();
        public List<Book> GetBooks() {
            return cart;
        }
        public void AddBook(Book bk) {
            cart.Add(bk);

        }
        public void Checkout() {
            List<int> ids = new List<int>();
            foreach (var book in cart)
            {
                ids.Add(book.id);
            }
            foreach (var book in App.lib.books)
            {
                if (ids.Contains(book.id)) {
                    book.availible = false;
                }
            }
            cart.Clear();
            Console.WriteLine("Your books have been checked out, have a nice day!");
        }
        public void RemoveBook() {

        }
        public void ShowCart()
        {
            foreach (var book in cart)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Title: " + book.title);
                Console.WriteLine("Author: " + book.author);
                Console.WriteLine("Pages: " + book.pages);
                Console.WriteLine("ID: " + book.id);
                Console.WriteLine("------------------------------\n");
            }
            if (cart.Count == 0)
            {
                Console.WriteLine("No Books in cart.\n");
            }

        }
    }
}