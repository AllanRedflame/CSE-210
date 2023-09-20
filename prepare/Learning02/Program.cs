using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job {
            _jobTitle = "Race Car Driver",
            _company = "NASCAR",
            _salary = "A lot of money. You're a race car driver."
        };


        Job job2 = new Job {
            _jobTitle = "Ice cream maker",
            _company = "IceCream.inc",
            _salary = "Not much money. But you get to eat a lot of ice cream." 
        };

        Resume resume1 = new Resume();

            resume1._name = "Frank Joe";

            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);


        resume1.Display();

    }
}