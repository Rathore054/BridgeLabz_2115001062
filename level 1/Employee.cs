using System;
public class Employee {
    public static string CompanyName = "Capgemini";
    public static int TotalNoEmployees=0;
    private string Name, Designation;
    private int ID;
    private readonly int employeeID;
    public static void DisplayTotalEmployees() {
        Console.WriteLine("TotalNoEmployees: "+TotalNoEmployees);

    }
    public Employee(string name,int id,string designation) { 
    this.Name = name;
        this.ID = id;   
        this.Designation=designation;
        TotalNoEmployees++;
    }
    public void display() { 
    if(this is Employee)
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("ID :"+ ID);
            Console.WriteLine("Designation :" + Designation);
        }
        
    }
     static void Main(String[] args)
 {
     Employee emp =new Employee("Udit",32432,"Data Analyst");
     Employee emp1 = new Employee("shivansh", 34234, "developer");
     emp.display();
     emp1.display();
     Employee.DisplayTotalEmployees();
 }   
}

