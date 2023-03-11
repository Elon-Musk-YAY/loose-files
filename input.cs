using System;

namespace CS {
    class Input {
        static void Main(string[] args) { 
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            if (name.Length > 0) {
            Console.WriteLine("Hello, "+name+"!");
            } else {
                Console.WriteLine("Hello!");
            }
                
        }
    }
}