using System;
using System.Collections.Generic;

class School {
    public string Name;
    public List<Student> Students = new List<Student>();
}

class Student {
    public string Name;
    public List<Course> Courses = new List<Course>();

    public void Enroll(Course course) {
        Courses.Add(course);
        course.Students.Add(this);
    }

    public void ShowCourses() {
        Console.WriteLine(Name + " is enrolled in:");
        foreach (var course in Courses) {
            Console.WriteLine(course.Title);
        }
    }
}

class Course {
    public string Title;
    public List<Student> Students = new List<Student>();

    public void ShowStudents() {
        Console.WriteLine("Students enrolled in " + Title + ":");
        foreach (var student in Students) {
            Console.WriteLine(student.Name);
        }
    }
}

class Program {
    static void Main() {
        School school = new School();
        school.Name = "GLA University";

        Student s1 = new Student();
        s1.Name = "Shivansh";

        Student s2 = new Student();
        s2.Name = "Udit";

        Course c1 = new Course();
        c1.Title = "Math";

        Course c2 = new Course();
        c2.Title = "Science";

        s1.Enroll(c1);
        s1.Enroll(c2);
        s2.Enroll(c1);

        s1.ShowCourses();
        s2.ShowCourses();
        c1.ShowStudents();
        c2.ShowStudents();
    }
}
