using System;



class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._JobTitle = "software engineer";
        job1._company = "Microsoft";
        job1._StartYear = 2009;
        job1._EndYear = 2023;
        job1.DisplayInformation();

        Job job2 = new Job();
        job2._JobTitle = "manager";
        job2._company = "Apple";
        job2._StartYear = 2010;
        job2._EndYear = 2020;
        job2.DisplayInformation();

        Resume resume1 = new Resume();
        resume1._name = "Andrew Chen";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();


    }
}