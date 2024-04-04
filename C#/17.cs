using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        
        // Read the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is an Armstrong number
        bool isArmstrong = IsArmstrong(number);

        // Print the result
        if (isArmstrong)
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }

    // Function to check if a number is Armstrong
    static bool IsArmstrong(int n)
    {
        int originalNumber, remainder, result = 0, digits = 0;

        originalNumber = n;

        // Count number of digits
        while (originalNumber != 0)
        {
            originalNumber /= 10;
            ++digits;
        }

        originalNumber = n;

        // Calculate sum of nth power of digits
        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += (int)Math.Pow(remainder, digits);
            originalNumber /= 10;
        }

        // Check if the number is Armstrong
        return result == n;
    }
}
