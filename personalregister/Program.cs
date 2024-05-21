using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Salary: {Salary:C}";
    }
}

class EmployeeRegister
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(string name, decimal salary)
    {
        Employee newEmployee = new Employee(name, salary);
        employees.Add(newEmployee);
    }

    public void PrintRegister()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeRegister register = new EmployeeRegister();

        while (true)
        {
            Console.Write("Enter employee name (or 'exit' to finish): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") break;

            Console.Write("Enter employee salary: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                register.AddEmployee(name, salary);
            }
            else
            {
                Console.WriteLine("Invalid salary input. Please try again.");
            }
        }

        Console.WriteLine("\nEmployee Register:");
        register.PrintRegister();
    }
}
