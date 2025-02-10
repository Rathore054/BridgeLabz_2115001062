using System;
using System.Collections.Generic;

abstract class Patient
{
    protected int patientId;
    protected string name;
    protected int age;

    public Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class InPatient : Patient
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge)
        : base(patientId, name, age)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }
}

class OutPatient : Patient
{
    private double consultationFee;

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }
}

class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>();
        patients.Add(new InPatient(1, "John", 45, 5, 2000));
        patients.Add(new OutPatient(2, "Alice", 30, 500));

        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine("Total Bill: " + patient.CalculateBill());
            Console.WriteLine();
        }
    }
}
