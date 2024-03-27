using System;

// RentalAgency Class
public class RentalAgency
{
    // Array to store fleet
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
        TotalRevenue = 0;
    }

    // Method to add vehicle to fleet
    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                return;
            }
        }
        Console.WriteLine("Fleet is full. Cannot add more vehicles.");
    }

    // Method to remove vehicle from fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == vehicle)
            {
                Fleet[i] = null;
                return;
            }
        }
        Console.WriteLine("Vehicle not found in fleet.");
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle, int days)
    {
        double rentalCost = vehicle.RentalPrice * days;
        TotalRevenue += rentalCost;
        Console.WriteLine($"Vehicle rented for {days} days. Rental cost: {rentalCost:C}");
    }
}
