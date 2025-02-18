using System;
using System.Collections.Generic;

abstract class CourseType { }

class ExamCourse : CourseType { }
class AssignmentCourse : CourseType { }

class Course<T> where T : CourseType
{
    public string CourseName { get; set; }

    public Course(string name)
    {
        CourseName = name;
    }

    public void Display()
    {
        Console.WriteLine("Course: " + CourseName + ", Type: " + typeof(T).Name);
    }
}

class Program
{
    static void Main()
    {
        List<Course<CourseType>> courses = new List<Course<CourseType>>
        {
            new Course<ExamCourse>("Mathematics"),
            new Course<AssignmentCourse>("Programming")
        };

        foreach (var course in courses)
        {
            course.Display();
        }
    }
}

