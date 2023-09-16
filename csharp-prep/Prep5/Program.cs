using System;
using System.Reflection;

class Program
{
    static void Main()
    {

        static void displayWelcome() {
            Console.WriteLine("Welcome to the program!");
        }

        displayWelcome();

        static string promptUserName() {
            Console.WriteLine("What's your name?");
            string nameQuery = Console.ReadLine();
            return nameQuery;
        }



        static int promptUserNumber() {
            Console.WriteLine("What's your favorite number?");
            string numberQuery = Console.ReadLine();
            return int.Parse(numberQuery);
        }

        static int squareNumber(int inputNumber) {
            int squaredNumber = inputNumber * inputNumber;
            return squaredNumber;
        }

        static void displayResult(string name, int square) {
            Console.WriteLine($"Your name is {name} and your squared number is {square}");

        }
        
        displayResult(promptUserName(), squareNumber(promptUserNumber()));
    }

}
