using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class HospitalTriage
{
    private PriorityQueue<Patient, int> triageQueue = new PriorityQueue<Patient, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

    public void AddPatient(string name, int severity)
    {
        triageQueue.Enqueue(new Patient(name, severity), severity);
    }

    public void TreatPatients()
    {
        Console.WriteLine("Treatment Order:");
        while (triageQueue.Count > 0)
        {
            Patient patient = triageQueue.Dequeue();
            Console.WriteLine(patient.Name + " (Severity: " + patient.Severity + ")");
        }
    }
}
