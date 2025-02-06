using System;
using System.Collections.Generic;

class Hospital {
    public string Name;
}

class Doctor {
    public string Name;
    public List<Patient> Patients = new List<Patient>();

    public void Consult(Patient patient) {
        Patients.Add(patient);
        patient.Doctors.Add(this);
        Console.WriteLine(Name + " is consulting " + patient.Name);
    }
}

class Patient {
    public string Name;
    public List<Doctor> Doctors = new List<Doctor>();
}

class Program {
    static void Main() {
        Doctor d1 = new Doctor();
        d1.Name = "Dr. Shivansh";

        Doctor d2 = new Doctor();
        d2.Name = "Dr. Udit";

        Patient p1 = new Patient();
        p1.Name = "Sujal";

        Patient p2 = new Patient();
        p2.Name = "Rahul";

        d1.Consult(p1);
        d1.Consult(p2);
        d2.Consult(p1);
    }
}
