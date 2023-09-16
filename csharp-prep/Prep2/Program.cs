using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("What is your grade?");
        string percentage = Console.ReadLine();
        int percentInt = int.Parse(percentage);

        string plusOrMinus;

        string finalGrade;

        if (percentage.Length >= 4) {
            Console.Write("That's too long");
        }

        else {
            if (percentInt >= 90) {
                finalGrade = "A";
            }

            else if  (percentInt >= 80) {
                finalGrade = "B";
            }

            else if (percentInt >= 70) {
                finalGrade = "C";
            }

            else if (percentInt >= 60) {
                finalGrade = "D";
            }

            else {
                finalGrade = "F";
            }

        if (percentInt == 100) {
            plusOrMinus = "";
        }

        else if (percentInt <= 60) {
            plusOrMinus = "";
        }

        else {

            if (percentInt % 10 >= 7) {
                plusOrMinus = "+";
                Console.WriteLine("+");
            }

            else if (percentInt % 10 <= 3) {
                plusOrMinus = "-";
                Console.WriteLine("-");
                
            }

            else {
                Console.WriteLine("blank");
                plusOrMinus = "";
            }

        }
    
        if (percentInt >= 70) {
            Console.Write($"Good job! You received a {finalGrade}{plusOrMinus} and you passed.");
        }

        if (percentInt <= 70) {
            Console.Write($"You got a {finalGrade}{plusOrMinus} and failed.");
        }
        }
    }
     
    }
