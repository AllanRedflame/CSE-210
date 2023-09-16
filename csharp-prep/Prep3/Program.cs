using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 10);


        int guessInt = 0;
        int guessCounter = 0;
        string continuing = "yes";

        while (continuing == "yes") {
            Console.WriteLine("Make a guess! (Between 1 and 10)");
            string guess = Console.ReadLine();
            guessInt = int.Parse(guess);

            if (guessInt > magicNumberInt) {
                Console.WriteLine("That's too high!");
                guessCounter ++;
            }

            else if (guessInt < magicNumberInt) {
                Console.WriteLine("That's too low!");
                guessCounter ++;
            }

            else {
                Console.WriteLine($"Good job, you got it! You made {guessCounter} guesses.");
                Console.WriteLine("Would you like to play again? (Enter yes or no)");
                continuing = Console.ReadLine();
                guessCounter = 0;
                
            }
    }

    }
}
