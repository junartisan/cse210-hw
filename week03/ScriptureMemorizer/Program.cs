using System;

class Program
{
    static void Main(string[] args)
    {
        // Example: Proverbs 3:5-6
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the LORD with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to hide more words or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words at a time
            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nProgram ended. Good job memorizing!");
    }
}