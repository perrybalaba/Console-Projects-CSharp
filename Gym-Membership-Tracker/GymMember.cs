using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Membership_Tracker
{
    public enum TheMembershipType
    {
        Basic,
        Premium,
        VIP
    }

    public class GymMember
    {
        // backing fields
        private string _memberName, _membershipType;
        private byte _age, _monthlyVisits;
        private decimal _monthlyFee;

        // assigning variables
        byte minAge = 16, maxAge = 65;

        // property - member name
        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }

        // property - membership type
        public string MembershipType
        {
            get { return _membershipType; }
            set { _membershipType = value; }
        }

        // property - age
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value < minAge ||  value > maxAge)
                {
                    throw new ArgumentOutOfRangeException($"Error! The member's age must be in between {minAge} to {maxAge} (inclusive).");
                }

                _age = value;
            }
        }

        
    }
}
