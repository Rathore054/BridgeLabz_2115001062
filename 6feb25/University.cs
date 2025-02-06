using System;
using System.Collections.Generic;

class University {
    public string Name;
    public List<Department> Departments = new List<Department>();
    public List<Faculty> Faculties = new List<Faculty>();

    public void AddDepartment(Department department) {
        Departments.Add(department);
    }

    public void AddFaculty(Faculty faculty) {
        Faculties.Add(faculty);
    }
}

class Department {
    public string Name;
}

class Faculty {
    public string Name;
}

class Program {
    static void Main() {
        University university = new University();
        university.Name = "GLA University";

        Department d1 = new Department();
        d1.Name = "Computer Science";

        Department d2 = new Department();
        d2.Name = "Physics";

        Faculty f1 = new Faculty();
        f1.Name = "Dr. Sujal";

        Faculty f2 = new Faculty();
        f2.Name = "Prof. Udit";

        university.AddDepartment(d1);
        university.AddDepartment(d2);
        university.AddFaculty(f1);
        university.AddFaculty(f2);

        Console.WriteLine("University: " + university.Name + " has departments:");
        foreach (var dept in university.Departments) {
            Console.WriteLine(dept.Name);
        }

        Console.WriteLine("Faculties in the university:");
        foreach (var fac in university.Faculties) {
            Console.WriteLine(fac.Name);
        }
    }
}
