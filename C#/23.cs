using System;

// Interface for Exam
interface Exam
{
    bool Pass(int mark);
}

// Interface for Classify
interface Classify
{
    string Division(int average);
}

// Class Result implementing both Exam and Classify interfaces
class Result : Exam, Classify
{
    // Implementing Pass method from Exam interface
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    // Implementing Division method from Classify interface
    public string Division(int average)
    {
        if (average >= 60)
        {
            return "First";
        }
        else if (average >= 50 && average < 60)
        {
            return "Second";
        }
        else
        {
            return "No division";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of Result class
        Result result = new Result();

        // Testing Pass method
        int mark1 = 70;
        Console.WriteLine($"Mark: {mark1}, Pass: {result.Pass(mark1)}");

        int mark2 = 40;
        Console.WriteLine($"Mark: {mark2}, Pass: {result.Pass(mark2)}");

        // Testing Division method
        int average1 = 65;
        Console.WriteLine($"Average: {average1}, Division: {result.Division(average1)}");

        int average2 = 55;
        Console.WriteLine($"Average: {average2}, Division: {result.Division(average2)}");

        int average3 = 45;
        Console.WriteLine($"Average: {average3}, Division: {result.Division(average3)}");
    }
}
