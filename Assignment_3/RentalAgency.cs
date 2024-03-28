namespace Assignment
{
    public class RentalAgency   //Created RentalAgency class
    {
        public Vehicle[] fleet;   // declaring fleet array to store vehicle data
        public int count;           // declaring count in array
        public double totalRevenue; //declaring totalrevenue

        public RentalAgency(int capacity)
        {
            fleet = new Vehicle[capacity];
            count = 0;
            totalRevenue = 0;
        }
        public void AddVehicle(Vehicle vehicle) //method created to add vehicle to fleet
        {
            if (count < fleet.Length)
            {
                fleet[count++] = vehicle;
            }
            else
            {
                Console.WriteLine("Fleet is full. Cannot add more vehicles.");
            }
        }

        public void RemoveVehicle(Vehicle vehicle)  //method created to remove vehicle from fleet
        {
            int index = Array.IndexOf(fleet, vehicle);
            if (index >= 0)
            {
                // Shift elements to the left to remove the vehicle
                for (int i = index; i < count - 1; i++)
                {
                    fleet[i] = fleet[i + 1];
                }
                count--;
            }
            else
            {
                Console.WriteLine("Vehicle not found in fleet.");
            }
        }

        public void RentVehicle(Vehicle vehicle, int days)  //method created to calculate the totalrevenue
        {
            if (Array.IndexOf(fleet, vehicle) >= 0)
            {
                totalRevenue += vehicle.rentalPrice * days;
                Console.WriteLine($"Vehicle rented for {days} days. Total cost: ${vehicle.rentalPrice * days} ");
            }
            else
            {
                Console.WriteLine("Vehicle not found in fleet.");
            }

        }
        public void Displayfleet()  //method to display the current fleet
        {
            for (int i = 0; i < count; i++)
            {
                fleet[i].DisplayDetails();
                Console.WriteLine("##############################################");

            }

        }



    }
}