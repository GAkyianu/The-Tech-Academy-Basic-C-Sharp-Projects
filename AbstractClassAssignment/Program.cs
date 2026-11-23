using System;

// Abstract class Person cannot be instantiated directly.
// It serves as a base class for other classes.
public abstract class Person
{
    // Property to store the person's first name.
    public string firstName { get; set; }

    // Property to store the person's last name.
    public string lastName { get; set; }

    // Abstract method that must be implemented by any class
    // inheriting from Person.
    public abstract void SayName();
}

// Employee inherits from the Person class.
public class Employee : Person
{
    // Override the abstract SayName method from Person.
    // This provides the actual implementation.
    public override void SayName()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}

// Main program class.
class Program
{
    // Entry point of the application.
    static void Main(string[] args)
    {
        // Create a new Employee object.
        Employee employee = new Employee();

        // Assign values to the firstName and lastName properties.
        employee.firstName = "Sample";
        employee.lastName = "Student";

        // Call the SayName method to display the employee's name.
        employee.SayName();

        // Keep the console window open until a key is pressed.
        Console.ReadLine();
    }
}