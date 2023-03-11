using System;

namespace LibApp {
    class App {
        private static int choice;
        public static User user = new User();
        public static Book[] bks = { new Book("Harry Potter", "J.K. Rowling", 700, true, 1000) };
        public static Library lib = new Library(bks);
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Library!");
            while (true) {
            Console.WriteLine("1: View All Books\n2: Checkout a book\n3: Show Cart\n4: Checkout Cart\n5: Exit");
            try {
                choice = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Please enter a valid choice in a correct format!\n");
            }
            Console.WriteLine("");
            switch (choice) {
                case 1:
                    lib.ShowAllBooks();
                    break;
                case 2:
                    lib.CheckoutBook();
                    break;
                case 3:
                    user.ShowCart();
                    break;
                case 4:
                    user.Checkout();
                    break;
                case 5:
                    Console.WriteLine("Have a good day!");
                    System.Environment.Exit(0);
                    break;
                }

        }
        }
    }
}