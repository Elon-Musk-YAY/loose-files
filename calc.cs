using System; 
namespace CS {
    class Calculator {
        static void Main(string[] args) {
            double first, second;
            char operation;
            Console.Write("Enter the first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operation: ");
            operation = Convert.ToChar(Console.ReadLine()[0]);
            Console.Write("Enter the second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            switch (operation) {
                case '+':
                    Console.WriteLine(first+" "+operation+" "+second+" = "+(first+second));
                    break;
                case '-':
                    Console.WriteLine(first+" "+operation+" "+second+" = "+(first-second));
                    break;
                case '*':
                    Console.WriteLine(first+" "+operation+" "+second+" = "+(first*second));
                    break;
                case 'x':
                    Console.WriteLine(first+" "+operation+" "+second+" = "+(first*second));
                    break;
                case '/':
                    Console.WriteLine(first+" "+operation+" "+second+" = "+(first/second));
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

        }
    }
}