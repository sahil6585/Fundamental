using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an array to store 5 numbers
        int[] numbers = new int[5];

        // Prompt the user to enter 5 numbers
        Console.WriteLine("Enter 5 numbers:");

        // Read the input numbers and store them in the array
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find the minimum number
        int min = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // Display the minimum number
        Console.WriteLine($"The minimum number is: {min}");
    }
}
