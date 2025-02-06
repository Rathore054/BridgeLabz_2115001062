using System;
using System.Collections.Generic;

class Student {
    public string Name;
    public List<Course> Courses = new List<Course>();

    public void EnrollCourse(Course course) {
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

class Professor {
    public string Name;
    public List<Course> Courses = new List<Course>();

    public void AssignProfessor(Course course) {
        Courses.Add(course);
        course.Professor = this;
    }
}

class Course {
    public string Title;
    public List<Student> Students = new List<Student>();
    public Professor Professor;

    public void ShowCourseDetails() {
        Console.WriteLine("Course: " + Title);
        Console.WriteLine("Professor: " + (Professor != null ? Professor.Name : "Not Assigned"));
        Console.WriteLine("Enrolled Students:");
        foreach (var student in Students) {
            Console.WriteLine(student.Name);
        }
    }
}

class Program {
    static void Main() {
        Student s1 = new Student();
        s1.Name = "Shivansh";

        Student s2 = new Student();
        s2.Name = "Udit";

        Professor p1 = new Professor();
        p1.Name = "Dr. Sujal";

        Course c1 = new Course();
        c1.Title = "Data Structures";

        s1.EnrollCourse(c1);
        s2.EnrollCourse(c1);
        p1.AssignProfessor(c1);

        c1.ShowCourseDetails();
    }
}
