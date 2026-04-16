using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list for activities
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        Running run = new Running("03 Nov 2022", 30, 4.8);
        Cycling bike = new Cycling("03 Nov 2022", 45, 15.0);
        Swimming swim = new Swimming("03 Nov 2022", 20, 20);

        // Add to the list
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        // Display summaries
        Console.WriteLine("Exercise Tracking Report:");
        Console.WriteLine("-------------------------");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}