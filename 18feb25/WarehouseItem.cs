using System;

abstract class JobRole
{
    public string JobTitle { get; set; }

    public JobRole(string title)
    {
        JobTitle = title;
    }

    public abstract void DisplayRole();
}

class SoftwareEngineer : JobRole
{
    public SoftwareEngineer() : base("Software Engineer") { }
    public override void DisplayRole() 
    { 
        Console.WriteLine("Job Role: Software Engineer"); 
    }
}

class DataScientist : JobRole
{
    public DataScientist() : base("Data Scientist") { }
    public override void DisplayRole() 
    { 
        Console.WriteLine("Job Role: Data Scientist"); 
    }
}

class Resume<T> where T : JobRole
{
    public string CandidateName { get; set; }
    public T Job { get; set; }

    public Resume(string name, T job)
    {
        CandidateName = name;
        Job = job;
    }

    public void DisplayResume()
    {
        Console.WriteLine("Candidate: " + CandidateName);
        Job.DisplayRole();
    }
}

class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("Alice", new SoftwareEngineer());
        Resume<DataScientist> resume2 = new Resume<DataScientist>("Bob", new DataScientist());

        resume1.DisplayResume();
        resume2.DisplayResume();
    }
}
