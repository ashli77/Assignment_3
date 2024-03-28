namespace rental
{
    public class RentalAgency   //Created RentalAgency class
    {
        public Vehicle[] fleet;     // Fleet array to store vehicle data
        public int count;           // Declaring Array
        public double totalRevenue; //Total Revenue

        public RentalAgency(int capacity)
        {
            fleet = new Vehicle[capacity];
            count = 0;
            totalRevenue = 0;
        }
        public void AddVehicle(Vehicle vehicle) // Add Vehicle
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

        public void RemoveVehicle(Vehicle vehicle)  // Remove vehicle from fleet
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

        public void RentVehicle(Vehicle vehicle, int days)  // Calculate the totalrevenue
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
        public void Displayfleet()  // Current fleet
        {
            for (int i = 0; i < count; i++)
            {
                fleet[i].DisplayDetails();
                Console.WriteLine("##############################################");

            }

        }



    }
}