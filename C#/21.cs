using System;

class Vehicle
{
    // Instance variable
    protected string vehicleType;

    // Constructor
    public Vehicle(string vehicleType)
    {
        this.vehicleType = vehicleType;
    }

    // Method to display vehicle information
    public virtual void Show()
    {
        Console.WriteLine("Vehicle Type: " + vehicleType);
    }
}

class Car : Vehicle
{
    // Instance variables specific to Car class
    private string modelType;
    private string companyName;

    // Constructor
    public Car(string vehicleType, string modelType, string companyName) : base(vehicleType)
    {
        this.modelType = modelType;
        this.companyName = companyName;
    }

    // Method to display car information
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Model Type: " + modelType);
        Console.WriteLine("Company Name: " + companyName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of Car class
        Car car = new Car("Sedan", "Honda City", "Honda");

        // Displaying car information
        Console.WriteLine("Car Information:");
        car.Show();
    }
}
