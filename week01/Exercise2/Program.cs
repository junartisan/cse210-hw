using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign ="";

        if (percent >= 90)
            {
            letter = "A";
            }
        else if (percent >=80)
            {
            letter = "B";
            }
        else if (percent <=70)
        {
            letter ="C";
        }
        else if (percent >=60)
        {
            letter ="D";
        }
        else 
        {
            letter ="F";
        }

        int lastDigit = percent % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }
        
        if (percent >= 93 )
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        

        if (percent >=70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}