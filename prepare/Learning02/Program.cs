using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Senior Full Stack Engineer";
        job1._company = "Super Cool Coders, Inc";
        job1._department = "Web Development";
        job1._salariedOrHourly = "S";
        job1._supervisorId = "12345";
        job1._wage = 125000.0f;

        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "Super School District";
        job2._department = "Cleaning and Sanitization";
        job2._salariedOrHourly = "H";
        job2._supervisorId = "54321";
        job2._wage = 15.0f;

        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._applicantName = "Harry Potter";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.DisplayDetails();
    }
}