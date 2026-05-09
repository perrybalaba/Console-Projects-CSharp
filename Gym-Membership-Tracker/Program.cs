using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Membership_Tracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // assigning variables
                uint memberCount = 1, basicCount = 1, premiumCount = 1, vipCount = 1;

                // creating objects of gym member class
                GymMember m1 = new GymMember("Daniel Smith", "Premium", 22, 20);
                GymMember m2 = new GymMember("Olivia Johnson", "VIP", 31, 17);
                GymMember m3 = new GymMember("Jason Miller", "Basic", 19, 30);

                // creating list + adding objects to the list
                List<GymMember> gList = new List<GymMember>();
                gList.Add(m1);
                gList.Add(m2);
                gList.Add(m3);

                // displaying member info
                foreach (GymMember m in gList)
                {
                    Console.WriteLine($"=== MEMBER #{memberCount++} ===");

                    m.CalculateMembershipFee();
                    m.CheckRewardEligibility();
                    m.DetermineActivityStatus();

                    Console.WriteLine(m.DisplayMemberInfo());
                    Console.WriteLine();
                }

                // displaying stats
                foreach (GymMember m in gList)
                {
                    Console.WriteLine("=== STATS ===");

                    if (m.MembershipType == "Basic")
                    {
                        Console.WriteLine($"Total Basic Members: {basicCount++}");
                    }
                    else if (m.MembershipType == "Premium")
                    {
                        Console.WriteLine($"Total Premium Members: {premiumCount}");
                    }
                    else
                    {
                        Console.WriteLine($"Total VIP Members: {vipCount}");
                    }

                    if (m.Visits > m1.Visits) // placeholder
                    {
                        Console.WriteLine($"Most Active Member: {m.MemberName} with {m.Visits} visits");
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
