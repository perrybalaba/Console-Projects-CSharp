using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Garage_Management_System
{

    public class Vehicle
    {
        public enum TheVehicleType
        {
            Car,
            Motorcycle,
            Truck
        }

        // backing fields
        private string _licensePlate, _ownerName, _vehicleType;
        private uint _hoursParked;
        private decimal _parkingFee;

        // assign variables
        uint minHours = 1, maxHours = 24, promotionHours = 5;
        decimal carFee = 4, motorcycleFee = 2, truckFee = 6, discount = 15;

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
                foreach (string vehicle in Enum.GetValues(typeof(TheVehicleType)))
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
        public Vehicle()
        {
            _licensePlate = null;
            _ownerName = null;
            _vehicleType = null;
            _hoursParked = 0;
            _parkingFee = 0;
        }

        // parametized constructor - accepts all fields except parking fee
        public Vehicle(string licensePlate_, string ownerName_, string vehicleType_, uint hoursParked_)
        {
            LicensePlate = licensePlate_;
            OwnerName = ownerName_;
            VehicleType = vehicleType_;
            HoursParked = hoursParked_;
        }

        // method - calculate parking fee
        public void CalculateParkingFee()
        {
            if (_vehicleType == "Car")
            {
                _parkingFee = _hoursParked * carFee;
            }
            else if (_vehicleType == "Motorcycle")
            {
                _parkingFee = _hoursParked * motorcycleFee;
            }
            else
            {
                _parkingFee = _hoursParked * truckFee;
            }
        }

        // method - applies special promotion
        public void ApplySpecialPromotion()
        {
            if (_hoursParked % promotionHours == 0)
            {
                _parkingFee -= (_parkingFee * discount);
            }
        }

        // to string
        public override string ToString()
        {
            return $"License Plate: {_licensePlate} \n Owner: {_ownerName} \n Vehicle Type: {_vehicleType} \n Hours Parked: {_hoursParked} \n Total Fee: {_parkingFee}";
        }

    }
}
