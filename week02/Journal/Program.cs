using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Search Keyword");
            Console.WriteLine("6. Exit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry.Date = DateTime.Now.ToShortDateString();
                entry.PromptText = prompt;
                entry.EntryText = response;
                entry.Mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == 5)
            {
                Console.Write("Enter keyword to search:");
                string keyword = Console.ReadLine();
                journal.SearchEntries(keyword);
            }
        }
    }
}