using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Ask your first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        //Ask your last name
        Console.Write ("What is yoru last name? ");
        string last = Console.ReadLine();
        
        //It will write your fullname
        Console.WriteLine ($" Your name is {first} {last}.");

    }
}