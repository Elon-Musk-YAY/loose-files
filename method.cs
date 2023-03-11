using System;
namespace CS {
    class Methods {
        static void Main(string[] args) {
            SayHi("Mike");
            SayHi("John");
            SayHi("Tom");
            double ans = Cube(3);
            Console.WriteLine(ans);
            Do();
        }
        static void SayHi(string name) {
            Console.WriteLine("Hello, "+name+ "!");
        }
        static double Cube(double start) {
            return Math.Pow(start, 3);
        }
        static void Do() {
            int index = 6;
            do {
                
                Console.WriteLine(index);
                index ++;
            } while (index <= 5);
        }
    }
}