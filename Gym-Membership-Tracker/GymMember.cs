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

        // property - member name
        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }
    }
}
