using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Goal {

    public static void ChangeFile(string file, string content) {
            
            string fileName = file;

    if (File.Exists(fileName))
    {
        using (StreamWriter writer = File.AppendText(fileName))
        {
            writer.WriteLine(content);
        }
    }
    else
    {
        File.WriteAllText(fileName, content);
    }
            
    }

    public static void Main() {
        
        List<string> goalList = new List<string>();
        int points = 0;
        
        while (true) {

            
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Delete file");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Record Event");
            Console.WriteLine("7. Quit");

            string menuQuery = Console.ReadLine();
            
            if (menuQuery.ToLower()  == "quit" || menuQuery == "7") {
                Console.WriteLine("Program ended.");
                break;
            }

            else if (menuQuery == "1") {
                goalList.Add(CreateGoal());
            }
            else if (menuQuery == "2") {

                for (int i = 0; i < goalList.Count; i++) {
                    Console.WriteLine($"{i + 1}. " + goalList[i]);

                    string[] line = goalList[i].Split("|");

                }

                
                

                Console.WriteLine("");
                Console.WriteLine($"You have {points} points. Press 'Enter' to continue.");
                Console.ReadLine();

            }
            else if (menuQuery == "3") {
                Console.Clear();
                Console.WriteLine("Choose the name of the file you would like to save to.");
                string file = Console.ReadLine();
                for (int i = 0; i < goalList.Count; i++) {
                    ChangeFile(file, goalList[i]);
                }
            }
            else if (menuQuery == "4") {
                
                    Console.Clear();
                    Console.WriteLine("Choose the name of the file you would like to save to.");
                    string file = Console.ReadLine();
                    File.Delete(file);
                    Console.WriteLine("Delete successful. Press 'Enter' to continue.");
                    Console.ReadLine();

                }
            
            else if (menuQuery == "5") {

                Console.WriteLine("Choose the name of the file you would like to load from.");
                string file = Console.ReadLine();

                try {
                    goalList = File.ReadAllLines(file).ToList();

                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred while reading the file: " + e.Message);
                }

                foreach (string line in goalList)
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
            }

            else if (menuQuery == "6") {
                Console.Clear();
                Console.WriteLine("Select a goal from your list (use numbers, e.g. 1, 2, 3...)");
                
                for (int i = 0; i < goalList.Count; i++) {
                    Console.WriteLine($"{i + 1}. " + goalList[i]);
                }



                string eventAnswer = Console.ReadLine();
                
                StringBuilder sb = new StringBuilder(string.Join("", goalList[Convert.ToInt32(eventAnswer)]));
                List<string> splitList = new List<string>();
                if (sb[0] == 'S') {

                    goalList[Convert.ToInt32(eventAnswer)] = sb.ToString();
                    splitList = goalList[Convert.ToInt32(eventAnswer)].Split('|').ToList(); 
                    points += Convert.ToInt32(splitList.Last());

                    sb[2] = 'X';

                    Console.WriteLine($"Congratulations! You finished your goal. You earned {Convert.ToInt32(splitList.Last())} points"); 
                    
                }
                else if (sb[0] == 'E') {

                    goalList[Convert.ToInt32(eventAnswer)] = sb.ToString();
                    splitList = goalList[Convert.ToInt32(eventAnswer)].Split('|').ToList(); 
                    points += Convert.ToInt32(splitList.Last());

                                    Console.WriteLine($"Congratulations! You finished your goal. You earned {Convert.ToInt32(splitList.Last())} points"); 

                }
                else if (sb[0] == 'C') {
                    if (sb[^3] != sb[^1]) {
                        goalList[Convert.ToInt32(eventAnswer)] = sb.ToString();
                        splitList = goalList[Convert.ToInt32(eventAnswer)].Split('|').ToList(); 
                        Console.WriteLine(Convert.ToInt32(splitList[^3]));
                        points += Convert.ToInt32(splitList[^3]);

                        Console.WriteLine($"Congratulations! You finished your goal. You earned {Convert.ToInt32(splitList[^3])} points"); 
                    }
                    else {

                        goalList[Convert.ToInt32(eventAnswer)] = sb.ToString();
                        splitList = goalList[Convert.ToInt32(eventAnswer)].Split('|').ToList(); 
                        points += Convert.ToInt32(splitList[^2]);
                        Console.WriteLine($"Congratulations! You finished your goal. You earned {Convert.ToInt32(splitList[^2])} points"); 

                        

                        sb[2] = 'X';
                        
                    }

                }

                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine(); 
                
            }
            
            else {
                Console.WriteLine("Sorry! I didn't recognize that. Type any number between 1 and 7.");
            }
            
        }
    }

    
    public static string CreateGoal() {

            Console.Clear();
            Console.WriteLine("Select a choice from the menu.");
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");




            while (true) {
                string goalQuery = Console.ReadLine();
                
                if (goalQuery == "1") {
                    return SimpleGoal.CreateSimple();

                }

                else if (goalQuery == "2") {
                    return EternalGoal.CreateEternal();
                }
            
                else if (goalQuery == "3") {
                    return CheckListGoal.CreateCheck();
                }

                else {
                    Console.WriteLine("Sorry, I didn't recognize that! (type 1, 2, or 3)");
                }
            }

        }


    class SimpleGoal {
        public static string CreateSimple() {

            Console.WriteLine("What is the name of your goal?");
            string simpleName = Console.ReadLine();

            Console.WriteLine("What is a short description of this goal?");
            string simpleDesc = Console.ReadLine();

            Console.WriteLine("How many points is this goal worth?");
            string simplePoints = Console.ReadLine();

            return $"S[ ] {simpleName}|Description: {simpleDesc}|{simplePoints}";
            
        }
    }

    class EternalGoal {

        public static string CreateEternal() {
            
            Console.WriteLine("What is the name of your goal?");
            string eternalName = Console.ReadLine();

            Console.WriteLine("What is a short description of this goal?");
            string eternalDesc = Console.ReadLine();

            Console.WriteLine("How many points is this goal worth?");
            string eternalPoints = Console.ReadLine();

            return $"E[ ] {eternalName}|Description: {eternalDesc}|{eternalPoints}";
        }
    }

    class CheckListGoal {
            public static string CreateCheck() {

            Console.WriteLine("What is the name of your goal?");
            string checkName = Console.ReadLine();

            Console.WriteLine("What is a short description of this goal?");
            string checkDesc = Console.ReadLine();

            Console.WriteLine("How many points is this goal worth?");
            string checkPoints = Console.ReadLine();

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            string checkBonus = Console.ReadLine();

            Console.WriteLine("How many bonus points will you receive?");
            string checkBonusPoints = Console.ReadLine();
            string total = "0";

            return $"C[ ] {checkName}|Description: {checkDesc}|{checkPoints}|{checkBonusPoints}|{total}/{checkBonus}";
        }
    }
}
