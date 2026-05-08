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
                    v.CalculateParkingFee();
                    v.ApplySpecialPromotion();
                    v.DisplayVehicleInfo();
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
