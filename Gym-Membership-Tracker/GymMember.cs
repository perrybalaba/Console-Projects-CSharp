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
        private byte _age, _visits;
        private decimal _monthlyFee;

        // assigning variables
        byte minAge = 16, maxAge = 65, minVisits = 20, maxVisits = 60, rewardVisits = 10;
        decimal basicFee = 25, premiumFee = 45, vipFee = 80;
        string reward, status;

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
            set 
            {
                foreach (Enum membership in Enum.GetValues(typeof(TheMembershipType)))
                {
                    if (value == membership.ToString())
                    {
                        _membershipType = membership.ToString();
                    }
                    else
                    {
                        throw new Exception($"Error! The only membership types available are: {TheMembershipType.Basic}, {TheMembershipType.Premium}, and {TheMembershipType.VIP}");
                    }
                }
            }
        }

        // property - age
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value < minAge ||  value > maxAge)
                {
                    throw new ArgumentOutOfRangeException($"Error! {_memberName}'s age must be in between {minAge} to {maxAge} (inclusive).");
                }

                _age = value;
            }
        }
        
        // property - visits
        public byte Visits
        {
            get { return _visits; }
            set
            {
                if (value < 0 || value > maxVisits)
                {
                    throw new ArgumentOutOfRangeException($"Error! {_memberName}'s total visits must be in between 0 to {maxVisits} (inclusive).");
                }

                _visits = value;
            }
        }

        // property - monthly fee
        public decimal MonthlyFee
        {
            get { return _monthlyFee; }
        }

        // default constructor
        public GymMember()
        {
            _memberName = string.Empty;
            _membershipType = string.Empty;
            _age = 0;
            _visits = 0;
            _monthlyFee = 0;
        }

        // parametized constructors - accepts all backing fields except for monthly fee\
        public GymMember(string memberName_, string membershipType_, byte age_, byte visits_)
        {
            MemberName = memberName_;
            MembershipType = membershipType_;
            Age = age_;
            Visits = visits_;
        }

        // method - calculate membership fee
        public void CalculateMembershipFee()
        {
            if (_membershipType == "Basic")
            {
                _monthlyFee = basicFee;
            }
            else if (_membershipType == "Premium")
            {
                _monthlyFee = premiumFee;
            }
            else
            {
                _monthlyFee = vipFee;
            }
        }

        // method - check reward eligibility
        public void CheckRewardEligibility()
        {
            if (_visits % rewardVisits == 0)
            {
                reward = $"Free Protein Shake";
            }
            else
            {
                reward = "None";
            }
        }

        // method - determine activity status
        public void DetermineActivityStatus()
        {
            if (_visits > minVisits )
            {
                status = "Active";
            }
            else
            {
                status = "Inactive";
            }
        }

        // method - display member info
        public string DisplayMemberInfo()
        {
            return $"Member: {_memberName} \nAge: {_age} \nMembership: {_membershipType} \nMonthly Fee: {_monthlyFee}$ \nVisits: {_visits} \nReward Earned: {reward} \nStatus: {status}";
        }


        
    }
}
