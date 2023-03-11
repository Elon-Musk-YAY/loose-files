using System;
namespace CS {
    class Classes {
        static void Main(string[] args) 
        {
            Book bk = new Book("Harry Potter","J.K. Rowling", 670);
            Console.WriteLine(bk.title+"  "+bk.author+"  "+bk.pages);
        }
    }
}