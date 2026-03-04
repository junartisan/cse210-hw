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
        
        //While statement will continue to ask if you don't encode 0
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
        
        //each of the inputed number will be listed and be identify in this condition
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        double ave = 0;
        //Look for all the number in the dictionary and get the average
        if (numbers.Count > 0)
        {
            ave = (double)sum / numbers.Count;
        }

        int highest = numbers[0];

        //Look for the highest number
        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }
        
        
        //Display Result
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