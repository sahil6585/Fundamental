using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the age
        Console.Write("Enter your age: ");
        
        // Read the age input from the user
        int age = Convert.ToInt32(Console.ReadLine());

        // Display message based on age category
        if (age < 12)
        {
            Console.WriteLine("You are a Kid.");
        }
        else if (age >= 12 && age <= 17)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 18 && age <= 60)
        {
            Console.WriteLine("You are an Adult.");
        }
        else
        {
            Console.WriteLine("You are a Senior Citizen.");
        }
    }
}
