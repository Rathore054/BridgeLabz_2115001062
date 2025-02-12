using System;

class Student
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public Student Next;

    public Student(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private Student head;

    public void AddAtBeginning(int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        newStudent.Next = head;
        head = newStudent;
    }

    public void AddAtEnd(int rollNumber, string name, int age, char grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }

    public void DeleteStudent(int rollNumber)
    {
        Student temp = head, prev = null;

        if (temp != null && temp.RollNumber == rollNumber)
        {
            head = temp.Next;
            return;
        }

        while (temp != null && temp.RollNumber != rollNumber)
        {
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null) return;

        prev.Next = temp.Next;
    }

    public void SearchStudent(int rollNumber)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                Console.WriteLine("Roll Number: " + temp.RollNumber + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }

    public void UpdateGrade(int rollNumber, char newGrade)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == rollNumber)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }

    public void Display()
    {
        Student temp = head;
        if (temp == null)
        {
            Console.WriteLine("No student records found.");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine("Roll Number: " + temp.RollNumber + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
            temp = temp.Next;
        }
    }

    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        list.AddAtBeginning(101, "Alice", 20, 'A');
        list.AddAtEnd(102, "Bob", 21, 'B');
        list.AddAtEnd(103, "Charlie", 22, 'C');

        Console.WriteLine("All Students:");
        list.Display();

        Console.WriteLine("\nSearch for Roll Number 102:");
        list.SearchStudent(102);

        Console.WriteLine("\nUpdating Grade for Roll Number 103:");
        list.UpdateGrade(103, 'A');
        list.Display();

        Console.WriteLine("\nDeleting Student with Roll Number 101:");
        list.DeleteStudent(101);
        list.Display();
    }
}
