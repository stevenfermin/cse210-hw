using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company_name = "Microsoft";
        job1._job_title = "Software Engineer";
        job1._start_year = "2019";
        job1._end_year = "2022";

        Job job2 = new Job();
        job2._company_name = "Apple";
        job2._job_title = "Manager";
        job2._start_year = "2022";
        job2._end_year = "2023";

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }

}