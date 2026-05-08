using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Garage_Management_System
{
    public class Vehicle
    {
        // backing fields
        private string _licensePlate, _ownerName, _vehicleType;
        private uint _hoursParked;
        private decimal _parkingFee;

        // assign variables
        uint minHours = 1, maxHours = 24;

        // property - license plate
        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        // property - owner name
        public string OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }

        // property - vehicle type
        public string VehicleType
        {
            get { return _vehicleType; }
            set
            {
                foreach (string vehicle in Enum.GetValues(typeof(Vehicle)))
                {
                    if (vehicle.Equals(value)) // if value equals to one of the vehicles in the enum
                    {
                        _vehicleType = vehicle;
                    }
                    else
                    {
                        throw new ArgumentException($"Error! This vehicle type {value} is not part of our system");
                    }
                }
            }
        }

        // property - hours parked
        public uint HoursParked
        {
            get { return _hoursParked; }
            set
            {
                if (value < minHours || value > maxHours)
                {
                    throw new ArgumentOutOfRangeException($"Error! The hours parked needs to be in between {minHours} hour and {maxHours} hours");
                }

                _hoursParked = value;
            }
        }

        // property - parking fee
        public decimal ParkingFee
        {
            get { return _parkingFee; }
        }

        // default constructor
        public Vehicle

    }
}
