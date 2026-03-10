using System;

public class Resume
{
    public string _name;
    
    //Make sure to initialized your list to a new List before you use it. 
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Notice the use of custom data type "Job" in this loop

        foreach (Job job in _jobs)
        {
            //This call the Display method on each job
            job.Display();
        }
    }
}