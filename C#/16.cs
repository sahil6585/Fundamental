using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        
        // Read the input string from the user
        string inputString = Console.ReadLine();

        // Check if the string is palindrome
        bool isPalindrome = IsPalindrome(inputString);

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

    // Function to check if a string is palindrome
    static bool IsPalindrome(string str)
    {
        // Convert the string to lowercase for case-insensitive comparison
        str = str.ToLower();

        // Iterate through the string from both ends to check if it is a palindrome
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
