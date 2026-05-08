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

    }
}
