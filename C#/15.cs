using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        
        // Read the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is palindrome
        bool isPalindrome = IsPalindrome(number);

        // Print the result
        if (isPalindrome)
        {
            Console.WriteLine("It is a palindrome.");
        }
        else
        {
            Console.WriteLine("It is not a palindrome.");
        }
    }

    // Function to check if a number is palindrome
    static bool IsPalindrome(int n)
    {
        int reversedNumber = 0;
        int originalNumber = n;

        // Reverse the number
        while (n > 0)
        {
            int digit = n % 10;
            reversedNumber = reversedNumber * 10 + digit;
            n /= 10;
        }

        // Check if the reversed number is equal to the original number
        return reversedNumber == originalNumber;
    }
}
