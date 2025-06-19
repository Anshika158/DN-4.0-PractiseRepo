using System;

public class Employee
{
    public int EmployeeId;
    public string Name;
    public string Position;
    public double Salary;

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Position: {Position}, Salary: {Salary}");
    }
}

public class EmployeeManager
{
    private Employee[] employees;
    private int count;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    public void AddEmployee(Employee emp)
    {
        if (count < employees.Length)
        {
            employees[count++] = emp;
            Console.WriteLine("Employee added.");
        }
        else
        {
            Console.WriteLine("Employee list is full.");
        }
    }

    public Employee SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
                return employees[i];
        }
        return null;
    }

    public void DeleteEmployee(int id)
    {
        int index = -1;
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            for (int i = index; i < count - 1; i++)
            {
                employees[i] = employees[i + 1];
            }
            count--;
            Console.WriteLine("Employee deleted.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void DisplayAll()
    {
        for (int i = 0; i < count; i++)
        {
            employees[i].Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager(5);

        manager.AddEmployee(new Employee(1, "Alice", "Developer", 60000));
        manager.AddEmployee(new Employee(2, "Bob", "Manager", 80000));
        manager.AddEmployee(new Employee(3, "Charlie", "Analyst", 50000));

        Console.WriteLine("\nAll Employees:");
        manager.DisplayAll();

        Console.WriteLine("\nSearching Employee with ID 2:");
        var emp = manager.SearchEmployee(2);
        if (emp != null)
            emp.Display();
        else
            Console.WriteLine("Employee not found.");

        Console.WriteLine("\nDeleting Employee with ID 2:");
        manager.DeleteEmployee(2);

        Console.WriteLine("\nAll Employees after deletion:");
        manager.DisplayAll();
    }
}
