//Class Motorcycle
using System;

namespace rental
{
    public class Motorcycle : Vehicle
    {
        public int engineCapacity;
        public string fuelType;        // Properties of the Vehicle
        public string hasFairing;

        public void Motorcycledata()
        {
            Console.WriteLine("Enter Engine Capacity:");
            engineCapacity = Convert.ToInt32(Console.ReadLine());   //Getting motorcycle data from customer

            Console.WriteLine("FuelType:");
            fuelType = Console.ReadLine();

            Console.WriteLine("Whether motorcycle has Fairing:");
            hasFairing = (Console.ReadLine());

        }



        public override void DisplayDetails()
        {

            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice} \n Engine Capacity: {engineCapacity}cc, Fuel Type: {fuelType}, Has Fairing: {hasFairing}");
        }
    }
}