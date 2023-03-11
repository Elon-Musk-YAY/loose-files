using System;
namespace CS {
    class Strings {
        static void Main(string[] args) {
            string phrase = "Giraffes " + "Are Cool";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Giraffe"));
            Console.WriteLine(phrase[0]);
            for(int i  =0; i< phrase.Length; i++) {
                Console.WriteLine("Letter: "+phrase[i]+" (Index: "+phrase.IndexOf(phrase[i])+")");
            }
            Console.WriteLine(phrase.Substring(phrase.IndexOf("Are"),3));
        }
    }
}