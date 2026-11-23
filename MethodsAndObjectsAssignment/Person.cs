using System;

// Create a class called Person
public class Person
{
    // Property to store the person's first name
    public string FirstName { get; set; }

    // Property to store the person's last name
    public string LastName { get; set; }

    // Method that displays the person's full name
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}