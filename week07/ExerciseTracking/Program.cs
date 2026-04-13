using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        Running run = new Running("03 Mar 2026", 30, 3.0);
        Cycling bike = new Cycling("04 Mar 2026", 45, 15.0);
        Swimming swim = new Swimming("05 Mar 2026", 20, 20);

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        // Iterate and display summaries
        Console.WriteLine("Activity Tracking Summary:");
        Console.WriteLine("--------------------------");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}