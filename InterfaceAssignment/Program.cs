using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object
            Employee employee = new Employee();

            // Set the employee's first name
            employee.FirstName = "John";

            // Set the employee's last name
            employee.LastName = "Smith";

            // Set the employee's ID
            employee.Id = 1;

            // Create an interface reference using polymorphism
            IQuittable quittable = employee;

            // Call the Quit method through the interface
            quittable.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
