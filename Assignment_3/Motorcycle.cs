using System;

namespace Assignment
{
    public class Motorcycle : Vehicle  // Creating motorcycle class
    {
        public int engineCapacity;
        public string fuelType;        // Declaring properties specific to motorcycle
        public string hasFairing;

        public void Motorcycledata()
        {
            Console.WriteLine("Enter engineCapacity:");
            engineCapacity = Convert.ToInt32(Console.ReadLine());   //Getting motorcycle data from customer

            Console.WriteLine("Enter fuelType:");
            fuelType = Console.ReadLine();

            Console.WriteLine("Enter motorcycle hasFairing:");
            hasFairing = (Console.ReadLine());

        }



        public override void DisplayDetails() // Overriden class
        {

            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice} \n Engine Capacity: {engineCapacity}cc, Fuel Type: {fuelType}, Has Fairing: {hasFairing}");
        }
    }
}