using System;

class Program
{
    static void Main()
    {

        Console.Write("What's your first name?");
        string firstName = Console.ReadLine();

        Console.Write("What's your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"My name's {lastName}. {firstName} {lastName}");
    }
}
