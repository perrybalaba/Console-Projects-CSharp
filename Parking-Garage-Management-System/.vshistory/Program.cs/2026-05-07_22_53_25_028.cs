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
                Vehicle v2 = new Vehicle(""

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
