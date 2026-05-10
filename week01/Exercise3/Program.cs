using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        
        while (response.ToLower() == "yes")
        {
        
            Random RandomGenerator = new Random();
            int magicNumber= RandomGenerator.Next(1,100);
            int guessCount = 0;

            int guess = -1;
            while (guess != magicNumber )
            {

                Console.Write("What is your guess? ");
                int guessNumber = int.Parse(Console.ReadLine());
                guessCount = guessCount + 1;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Guess Lower.");
                    Console.WriteLine("");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Guess Higher.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You Guessed Right.");
                    Console.WriteLine($"It took you {guessCount} guess.");
                    Console.WriteLine("");
                    Console.Write("Would you like to play Again, 'yes' or 'no' ");
                    response = Console.ReadLine();
                    if (response == "no")
                    {
                        Console.WriteLine("NICE TIME");
                        break;
                    }
                    Console.WriteLine("");    
                }    
            }    
        }        
    }
} 