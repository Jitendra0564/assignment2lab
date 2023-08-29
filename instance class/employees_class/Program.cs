using System;

namespace employees_class
{
   class Employee
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Constructor
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: ${Salary}");
            Console.ReadKey();
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an employee object
            Employee employee = new Employee("aditya mishra", 21, 80000.00);

            // Displaying employee details using the method
            employee.DisplayDetails();
        }
    }

}
