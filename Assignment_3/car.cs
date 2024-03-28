// Class Car
namespace Assignment
{
    class Car : Vehicle   
    {
        public int seats;
        public string engineType;
        public string transmission;   // Properties of cars
        public string convertible;


        public void Cardata()
        {
            Console.WriteLine("Enter number of seats:");   // Getting Car data to be added from customer
            seats = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car engineType:");
            engineType = Console.ReadLine();

            Console.WriteLine("Enter car transmission:");
            transmission = Console.ReadLine();

            Console.WriteLine("Enter car convertible:");
            convertible = (Console.ReadLine());
        }


        public override void DisplayDetails()
        {

            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice}Seats: {seats}, Engine Type: {engineType},\n Transmission: {transmission}, Convertible: {(convertible)}");
        }
    }
}