using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter three numbers
        Console.Write("Enter three numbers separated by spaces: ");
        
        // Read the input numbers from the user
        string[] inputNumbers = Console.ReadLine().Split(' ');

        // Parse the input strings to integers
        int num1 = Convert.ToInt32(inputNumbers[0]);
        int num2 = Convert.ToInt32(inputNumbers[1]);
        int num3 = Convert.ToInt32(inputNumbers[2]);

        // Find the minimum of the three numbers using conditional operator
        int min = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);

        // Print the minimum number
        Console.WriteLine($"The minimum of {num1}, {num2}, and {num3} is: {min}");
    }
}
