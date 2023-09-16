using System;

class Program
{
    static void Main()
    {

        
        
        List<string> numberStr = new List<string>();  

        string input;
        string continuing = null;
        decimal sumValue = default;
        
        while (continuing != "0") {
            Console.WriteLine("Add a number (0 to exit)");
            input = Console.ReadLine(); 
            if (int.Parse(input) != 0) {
                numberStr.Add(input);
            }
            else {
                continuing = "0";
            }
        }



        List<int> numberInt = numberStr.ConvertAll(int.Parse);

        if (numberStr.Count >= 1) {
            for (int i = 0; i < numberStr.Count; i++) {
            sumValue += numberInt[i];
        }
        }

        Console.WriteLine(String.Join(",", numberStr)); 
        Console.WriteLine("The sum value is " + sumValue);
        Console.WriteLine("The average is " + sumValue / numberStr.Count);

        int highestValue = 0;
        
        foreach (string value in numberStr) {
            if (int.Parse(value) > highestValue) {
                highestValue = int.Parse(value);
            }
        }

        Console.WriteLine("The highest value is " + highestValue);

        int lowestValue = 1000000000;

        foreach (string value in numberStr) {
            if (int.Parse(value) < lowestValue) {
                lowestValue = int.Parse(value);
            }
        }

        int smallestAbsolute = numberInt.Min(i => (Math.Abs(0 - i), i)).i;

        Console.WriteLine("The lowest value is " + lowestValue);
        Console.WriteLine("the closest value to zero is " + smallestAbsolute);
        numberInt.Sort();
        Console.WriteLine("Your list in ascending order is this:\n" + String.Join(",", numberInt));    
}
}
