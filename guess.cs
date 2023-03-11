using System;
namespace CS {
    class Guessing {
        static void Main(string[] args) {
            string secretWord = "giraffe";
            string guess = "";
            int guesses = 0;
            int guessLimit = 5;
            while (guess != secretWord && guesses <=guessLimit) {
                if (guesses == 5) {
                    Console.WriteLine("You lose! The word was " + secretWord);
                    break;
                }
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                guesses++;
            } 
            if (guesses <= guessLimit) {
            Console.WriteLine("Congrats! You got it right!");
            guesses = 0;
            }
            guesses = 0;
            secretWord = "amazing";
            do {
                if (guesses == 5) {
                    Console.WriteLine("You lose! The word was " + secretWord);
                    break;
                }
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                guesses ++;
            } while (guess != secretWord && guesses <= guessLimit);
            if (guesses <= guessLimit) {
            Console.WriteLine("Congrats! You got it right!");
            }
        }
    }
}