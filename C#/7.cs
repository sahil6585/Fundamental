using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        
        // Read the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }
}
