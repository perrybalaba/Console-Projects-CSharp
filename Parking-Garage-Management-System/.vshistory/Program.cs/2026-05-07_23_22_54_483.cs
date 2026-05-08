using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Garage_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // assign variables
                uint vehicleCount = 1, truckCount = 1, carCount = 1, motorcycleCount = 1;

                // creating vehicles
                Vehicle v1 = new Vehicle("ABC123", "Sarah Lee", "Car", 5);
                Vehicle v2 = new Vehicle("TRK900", "Mike Brown", "Truck", 12);
                Vehicle v3 = new Vehicle("MOTO77", "Emma Wilson", "Motorcycle", 7);

                // list
                List <Vehicle> vList = new List<Vehicle>();
                vList.Add(v1);
                vList.Add(v2);
                vList.Add(v3);

                // display info
                foreach (Vehicle v in vList)
                {
                    Console.WriteLine($"=== VEHICLE #{vehicleCount++} ===");
                    v.CalculateParkingFee();
                    v.ApplySpecialPromotion();
                    v.DisplayVehicleInfo();
                    Console.WriteLine();
                }

                // display stats
                foreach (Vehicle v in vList)
                {
                    // determine how many vehicle types are parked
                    if (v.VehicleType == "Car")
                    {
                        Console.WriteLine($"=== TOTAL CARS PARKED === \n Total Cars Parked: {carCount++}");
                    }
                    else if (v.VehicleType == "Motorcycle")
                    {
                        Console.WriteLine($"=== TOTAL MOTORCYCLES PARKED === \n Total Motorcycles Parked: {truckCount++}");
                    }
                    else
                    {
                        Console.WriteLine($"=== TOTAL TRUCKS PARKED === \n Total Trucks Parked: {truckCount++}");
                    }
                    Console.WriteLine();

                    // find the owner who pays the highest parking fee
                    if (v.ParkingFee > v1.ParkingFee) // placeholder
                    {
                        Console.WriteLine($"=== HIGHEST PARKING FEE=== \n {v.OwnerName} - {v.ParkingFee}$");
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
