using System;
using System.Threading;

Activity.Intro();
public class Activity {

    public static void Intro() {
        
        string InputString = "None";

        while (InputString != "quit") {

            Console.WriteLine("Welcome to the thing!");
            Console.WriteLine("");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit");

            InputString = Console.ReadLine();

            if (InputString != "1" || InputString != "2" || InputString != "3") {

            }
            Console.WriteLine("How much time do you have? (In seconds)");
            string totalTime = Console.ReadLine();

            if (InputString == "1") {
                BreathingActivity.BreathNow(Convert.ToInt32(totalTime));
            }
            else if (InputString == "2") {
                ReflectingActivity.ReflectNow(Convert.ToInt32(totalTime));
            }
            else if (InputString == "3") {
                ListingActivity.ListingNow(Convert.ToInt32(totalTime));
            }
            else if (InputString == "4") {
                Console.WriteLine("Program ended.");
                break;
            }
            Console.WriteLine("\nWell done!");
            Spinner(1);
            Console.Clear();
        }

        }
    
    public static void Timers(int timing) {
        for (int i = timing; i > 0; i--) {
            Console.Write("\b \b" + i);
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
    }

    public static void Spinner(int time) {
        for (int i = 4; i > 0; i--) {
            Console.Write("\b \b" + "-");
            Thread.Sleep(time * 1000 / 4);
            Console.Write("\b \b" + "/");
            Thread.Sleep(time * 1000 / 4);
            Console.Write("\b \b" + "|");
            Thread.Sleep(time * 1000 / 4);
            Console.Write("\b \b" + "\\");
            Thread.Sleep(time * 1000 / 4);
        }
        Console.Write("\b \b");
    }
    
    class BreathingActivity {

        public static void BreathNow(int duration) { 

            Console.Clear();
            Console.WriteLine("This activity will help you practice your breathing.\n");
            Console.WriteLine("Would you like to do a normal breathing exercise or a box breathing exercise?" +
            " Answer 1 for normal and 2 for box breathing.");
            string answer = Console.ReadLine();
            Console.WriteLine("Get ready...");
            Spinner(1);
            Console.Clear();
            if (answer == "1") {
                for (int i = 0; i <= duration/8; i++) {
                Console.Write("Breath in....");
                Timers(4);
                Console.WriteLine("");
                Console.Write("Breath out....");
                Timers(4);
                Console.WriteLine("");
            }
            }
            if (answer == "2") {
                for (int i = 0; i <= duration/16; i++) {
                    Console.Write("Breathe in....");
                    Timers(4);
                    Console.WriteLine("");
                    Console.Write("Hold....");
                    Timers(4);
                    Console.WriteLine("");
                    Console.Write("Breathe out....");
                    Timers(4);
                    Console.WriteLine("");
                    Console.Write("Hold....");
                    Timers(4);
                    Console.WriteLine("");
                }
            }
            }   
        }
    
    class ReflectingActivity {

        public static void ReflectNow(int duration) {
            Random random = new Random();
            List<string> prompts = new List<string> () {
            "Think about a time you did something difficult.",
            "Think of a time you stood up for someone",
            "Think of a time when you did something truly selfless",
            "Think of a time you helped someone in need"
            };
            List<string> questions = new List<string>() {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            Console.Clear();
            Console.WriteLine("Welcome to the reflecting activity!");
            Console.WriteLine("");
            Console.WriteLine("Get ready...");
            Spinner(1);
            Console.Clear();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("\n--" + prompts[random.Next(0, prompts.Count)] + "--\n");
            Console.WriteLine("When you've thought of something, press 'Enter' to continue");
            Console.ReadLine();
            Console.Write("Consider each of the following questions. You may begin in:  ");
            Timers(5);
            Console.Clear();
        
            for (int i = 0; i < Convert.ToInt32(duration) / 8.4; i++) {
                Random newRandom = new Random();
                Console.Write("\n" + questions[random.Next(0, questions.Count)]+ "  ");
                Spinner(2);
            }
        }
    }
    class ListingActivity {
        static int _x = 0;
        private static Timer timer;
        private static string userInput = string.Empty;

        private static void TimerCallBack(object state)
        {
            Console.WriteLine("Time's up!");
            Console.WriteLine("You made " + _x + " entries.");

        }

        private static Thread inputThread;

    private static void ReadUserInput()
    {
        Console.WriteLine("Begin typing.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input != null)
            {
                userInput += input + Environment.NewLine;
                _x += 1;
                
            }
        }
    }
        public static void ListingNow(int duration) {

            List<string> ListPrompts = new List<string>() {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            List<string> responses = new List<string>();

            Random random = new Random();

            Console.Clear();
            Console.WriteLine("Welcome to the reflecting activity!");
            Console.WriteLine("This activity is meant to help you improve your gratitude by reflecting on " +
            "the things you're thankful for in life. Press 'Enter'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Consider the following question: \n" + ListPrompts[random.Next(0, ListPrompts.Count)]);
            Console.Write("Think about it for....");
            Timers(9);

            timer = new Timer(TimerCallBack, null, duration * 1000, Timeout.Infinite);

            inputThread = new Thread(ReadUserInput);
            inputThread.Start();

            Thread.Sleep(duration * 1000 + 4000);
        }
    }
}
