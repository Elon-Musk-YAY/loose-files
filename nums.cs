using System;
namespace CS {
    class Ints {
        static void Main(string[] args) {
            Console.WriteLine(5+8);
            Console.WriteLine((int)5.0 /2);
            Console.WriteLine((double)5.0 /2);
            int num = 7;
            Console.WriteLine("\n"+num);
            num --;
            Console.WriteLine(num);
            num ++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Pow(50,2));
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Sqrt(-1));
            int x, y;
            x = 4; y= 90;
            Console.WriteLine(Math.Max(x,y));
            Console.WriteLine(Math.Round(4.501111,3));
        }
    }
}