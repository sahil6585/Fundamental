using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        
        // Read the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum of the digits of the number
        int sum = CalculateSumOfDigits(number);

        // Print the sum of the digits
        Console.WriteLine($"The sum of the digits of {number} is: {sum}");
    }

    // Function to calculate the sum of the digits of a number
    static int CalculateSumOfDigits(int n)
    {
        int sum = 0;

        // Iterate through each digit of the number and add it to the sum
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}
