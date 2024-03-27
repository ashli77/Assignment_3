using System;

// Motorcycle Class
public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, double rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Constructor with user input
    public Motorcycle()
        : base("", "", 0, 0)
    {
        Console.WriteLine("Enter Motorcycle details:");
        Console.Write("Model: ");
        Model = Console.ReadLine();
        Console.Write("Manufacturer: ");
        Manufacturer = Console.ReadLine();
        Console.Write("Year: ");
        Year = int.Parse(Console.ReadLine());
        Console.Write("Rental Price: ");
        RentalPrice = double.Parse(Console.ReadLine());
        Console.Write("Engine Capacity: ");
        EngineCapacity = int.Parse(Console.ReadLine());
        Console.Write("Fuel Type: ");
        FuelType = Console.ReadLine();
        Console.Write("Has Fairing (true/false): ");
        HasFairing = bool.Parse(Console.ReadLine());
    }

    // Method to display motorcycle details
    public override void DisplayDetails()
    {
        Console.WriteLine("Motorcycle Details:");
        Console.WriteLine($"Engine Capacity: {EngineCapacity}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Has Fairing: {HasFairing}");
    }
}
