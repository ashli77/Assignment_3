// Class Vehicle
namespace rental
{
    public abstract class Vehicle
    {
        public string model;
        public string manufacturer;  // Declaring vehicle class properties
        public int year;
        public double rentalPrice;



        public abstract void DisplayDetails();  //Creating abstract method

    }
}