using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startyear = "2020";
        job1._endyear = "2024";

        job job2 = new job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startyear = "2018";
        job2._endyear = "2020";

        resume myResume = new resume();
        myResume._name = "Adonis Lebron";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}