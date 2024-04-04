using System;

// Enum defining days of the week
enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        // Using enums to represent days of the week
        DayOfWeek today = DayOfWeek.Friday;

        // Displaying today's day of the week
        Console.WriteLine("Today is: " + today);
    }
}
