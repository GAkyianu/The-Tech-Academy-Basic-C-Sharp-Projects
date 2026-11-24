using System;

namespace InterfaceAssignment
{
    // Employee class implements the IQuittable interface
    class Employee : IQuittable
    {
        // Stores the employee's first name
        public string FirstName { get; set; }

        // Stores the employee's last name
        public string LastName { get; set; }

        // Stores the employee's ID
        public int Id { get; set; }

        // Implementation of the Quit method required by the interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }
}