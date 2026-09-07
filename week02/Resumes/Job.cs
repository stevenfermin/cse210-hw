using System;

public class Job
{
    public string _company_name;
    public string _job_title;

    public string _start_year;
    public string _end_year;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_job_title} at {_company_name}, {_start_year} - {_end_year}");
    }
}
