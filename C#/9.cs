using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to find its factorial: ");
        
        // Read the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Calculate the factorial of the number
        long factorial = CalculateFactorial(number);

        // Print the factorial
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }

    // Function to calculate factorial recursively
    static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}
