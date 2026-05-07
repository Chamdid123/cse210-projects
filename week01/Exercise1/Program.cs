using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("what is your last name? ");
        string name = Console.ReadLine();

        Console.WriteLine($"Your name is {name}, {first_name} {name}");
    }
}