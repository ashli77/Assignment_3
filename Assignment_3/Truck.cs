// Class Truck
using System;
using System.Reflection;

namespace Assignment
{
    public class Truck : Vehicle
    {
        private int capacity;
        private string truckType;     // Declaring Properties specific to Truck class
        private string fourWheelDrive;




        public void Truckdata()
        {
            Console.WriteLine("Enter the capacity:");
            capacity = Convert.ToInt32(Console.ReadLine());  // Getting truck data from customer

            Console.WriteLine("Enter the truckType:");
            truckType = Console.ReadLine();

            Console.WriteLine("Enter if fourWheelDrive:");
            fourWheelDrive = (Console.ReadLine());
        }

        public int Capacity
        {
            get { return capacity; }  //get value and set value declared
            set { capacity = value; }
        }

        public string TruckType
        {
            get { return truckType; }
            set { truckType = value; }
        }

        public string FourWheelDrive
        {
            get { return fourWheelDrive; }
            set { fourWheelDrive = value; }
        }

        public override void DisplayDetails()
        {

            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice} \n Capacity: {Capacity} tons, Truck Type: {TruckType}, Four-Wheel Drive: {(fourWheelDrive)}");
        }
    }
}