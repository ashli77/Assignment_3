using System;

// Car Class
public class Car : Vehicle
{
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    // Constructor
    public Car(string model, string manufacturer, int year, double rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    // Constructor with user input
    public Car()
        : base("", "", 0, 0)
    {
        Console.WriteLine("Enter Car details:");
        Console.Write("Model: ");
        Model = Console.ReadLine();
        Console.Write("Manufacturer: ");
        Manufacturer = Console.ReadLine();
        Console.Write("Year: ");
        Year = int.Parse(Console.ReadLine());
        Console.Write("Rental Price: ");
        RentalPrice = double.Parse(Console.ReadLine());
        Console.Write("Seats: ");
        Seats = int.Parse(Console.ReadLine());
        Console.Write("Engine Type: ");
        EngineType = Console.ReadLine();
        Console.Write("Transmission: ");
        Transmission = Console.ReadLine();
        Console.Write("Convertible (true/false): ");
        Convertible = bool.Parse(Console.ReadLine());
    }

    // Method to display car details
    public override void DisplayDetails()
    {
        Console.WriteLine($"Car Details:");
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice:C}");
        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
    }
}
