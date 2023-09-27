using System;
using System.Diagnostics.Tracing;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;



class Journal {

    public static void Print() {
        string savedEntry = "blank";
        string filename = "entry.txt";

        while (true) {

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Delete");
        Console.WriteLine("6. Quit");

        int x = Int32.Parse(Console.ReadLine());

        if (x == 6) {
            break;
        }
        else {

            if (File.Exists(filename)) {
                //Continue
            }
            else {
                using (FileStream fs = File.Create("entry.txt"))
                {

                }
            }

            string[] lines = System.IO.File.ReadAllLines(filename);

            List<string> entryList = new();

            string generatedPrompt = PromptGenerator.ReturnPrompt();

            if (x == 1) {
                Console.WriteLine(generatedPrompt);
                string journalEntry = Console.ReadLine();
                savedEntry = journalEntry;
            }

            else if (x == 2) {
                foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            }

            else if (x == 3) {
                Console.WriteLine("Type the file name you want to load from. (default entry.txt)");
                filename = Console.ReadLine();
                if (File.Exists(filename)) {
                    Console.WriteLine("Load successful.");
                }
                else {
                    Console.WriteLine(@"Sorry. My code couldn't find your file.
returning you to default file (entry.txt).");
                    filename = "entry.txt";
                }

            }

            else if (x == 4) {

                

                using (StreamWriter outputFile = File.AppendText(filename)) {

                
                outputFile.WriteLine($"{Entry.DisplayThing()}");
                outputFile.WriteLine($"{generatedPrompt}");
                outputFile.WriteLine($"{savedEntry}");
                outputFile.WriteLine(" ");
                Console.WriteLine("Save successful");
            }
            }

            else if (x == 5) {
                Console.WriteLine("Are you sure you want to delete the contents of your file? (type yes or no).");
                string answer = Console.ReadLine();

                if (answer == "yes") {
                    File.WriteAllText(filename, String.Empty); 
                    Console.WriteLine("Delete successful.");
                }

                else if (answer == "no") {
                    Console.WriteLine("Delete cancelled.");
                }

                else {
                    Console.WriteLine("Woah. I didn't understand any of that. I'll just assume you meant no.");
                    Console.WriteLine("Delete cancelled.");
                }


            }

        }
    }
    }




    
    static void Main()
{


    Console.WriteLine(PromptGenerator.ReturnPrompt());
    Console.WriteLine(Entry.DisplayThing());
    Journal.Print();


}
    
}

class Entry {

    public static string DisplayThing() {
        
        return $" {DateTime.Now.ToString("M/d/yyyy")}";
    }

}

class PromptGenerator {


    public static string ReturnPrompt() {

        List<string> prompts = new List<string>() {
        "What's something that is interesting that happened today?",
        "What's something you are thankful for today?",
        "What did you accomplish today?",
        "What was the weather like today?",
        "What did you have for breakfast?"
    };


        Random random = new Random();
        int num = random.Next(0, 5);

        return prompts[num];
    }
    
}