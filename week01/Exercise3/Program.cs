using System;

class Program
{
    static void Main(string[] args)
    {
        
        string response;

        //Do the loop if the user enter yes answer
        do
        {
            // Random Number   
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guess = -1;
            
            Console.WriteLine("Guest a number between 1 to 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You've guess it");
            }
            }
            // Ask if the user will continue to play
            Console.Write("You want to play again? (yes/no): ");
            response = Console.ReadLine().ToLower();

        } while (response == "yes");
        
        Console.WriteLine ("Thanks for playing");
        
    }
}