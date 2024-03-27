using System;

// Truck Class
public class Truck : Vehicle
{
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor
    public Truck(string model, string manufacturer, int year, double rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Constructor with user input
    public Truck()
        : base("", "", 0, 0)
    {
        Console.WriteLine("Enter Truck details:");
        Console.Write("Model: ");
        Model = Console.ReadLine();
        Console.Write("Manufacturer: ");
        Manufacturer = Console.ReadLine();
        Console.Write("Year: ");
        Year = int.Parse(Console.ReadLine());
        Console.Write("Rental Price: ");
        RentalPrice = double.Parse(Console.ReadLine());
        Console.Write("Capacity: ");
        Capacity = int.Parse(Console.ReadLine());
        Console.Write("Truck Type: ");
        TruckType = Console.ReadLine();
        Console.Write("Four Wheel Drive (true/false): ");
        FourWheelDrive = bool.Parse(Console.ReadLine());
    }

    // Method to display truck details
    public override void DisplayDetails()
    {
        Console.WriteLine($"Truck Details:");
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice:C}");
        Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four Wheel Drive: {FourWheelDrive}");
    }
}
