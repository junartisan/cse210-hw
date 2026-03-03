using System;
using System.Linq.Expressions;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //using LoopExpression method
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        double ave = 0;

        if (numbers.Count > 0)
        {
            ave = (double)sum / numbers.Count;
        }

        int highest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }
        
        

        Console.WriteLine ($"The sum is : {sum}");
        Console.WriteLine($"The average number given : {ave}");
        Console.WriteLine($"The highest number is: {highest}");
        Console.WriteLine($"The sorted list are:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }   
}