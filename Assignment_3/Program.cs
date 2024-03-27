using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of different vehicle types
        Car car1 = new Car("Civic", "Honda", 2022, 50, 5, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("F-150", "Ford", 2021, 80, 4, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2020, 40, 1000, "Petrol", true);

        // Create Rental Agency
        RentalAgency rentalAgency = new RentalAgency(10);

        int choice;
        do
        {
            // Display options
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Rent a Vehicle");
            Console.WriteLine("2. Add a Vehicle");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Rent a vehicle
                    RentVehicle(rentalAgency, car1, truck1, bike1);
                    break;
                case 2:
                    // Add a vehicle
                    AddVehicle(rentalAgency);
                    break;
                case 3:
                    // Exit
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        } while (choice != 3);
    }

    // Method to rent a vehicle
    static void RentVehicle(RentalAgency rentalAgency, Car car1, Truck truck1, Motorcycle bike1)
    {
        // Display vehicle details
        Console.WriteLine("Available Vehicles:");
        Console.WriteLine("1. Car");
        car1.DisplayDetails();
        Console.WriteLine("2. Truck");
        truck1.DisplayDetails();
        Console.WriteLine("3. Motorcycle");
        bike1.DisplayDetails();

        // Prompt user to select a vehicle
        Console.WriteLine("\nEnter the number of the vehicle you want to rent:");
        int choice = int.Parse(Console.ReadLine());

        Vehicle selectedVehicle = null;
        switch (choice)
        {
            case 1:
                selectedVehicle = car1;
                break;
            case 2:
                selectedVehicle = truck1;
                break;
            case 3:
                selectedVehicle = bike1;
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        if (selectedVehicle != null)
        {
            // Prompt user for number of days
            Console.WriteLine("Enter the number of days you want to rent the vehicle:");
            int days = int.Parse(Console.ReadLine());

            // Rent the selected vehicle
            rentalAgency.RentVehicle(selectedVehicle, days);

            // Remove the selected vehicle from the fleet
            rentalAgency.RemoveVehicle(selectedVehicle);
        }
    }

    // Method to add a vehicle
    static void AddVehicle(RentalAgency rentalAgency)
    {
        Console.WriteLine("Select vehicle type to add:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Truck");
        Console.WriteLine("3. Motorcycle");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Add a car
                Car newCar = new Car();
                rentalAgency.AddVehicle(newCar);
                Console.WriteLine("Car added successfully.");
                break;
            case 2:
                // Add a truck
                Truck newTruck = new Truck();
                rentalAgency.AddVehicle(newTruck);
                Console.WriteLine("Truck added successfully.");
                break;
            case 3:
                // Add a motorcycle
                Motorcycle newMotorcycle = new Motorcycle();
                rentalAgency.AddVehicle(newMotorcycle);
                Console.WriteLine("Motorcycle added successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
