using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();

        Job1._company = "Anthropic";
        Job1._jobTitle = "Software Engineer";
        Job1._startYear = 2020;
        Job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Palantir";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Gary Murdock";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
    
    