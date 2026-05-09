# 2. Smart Gym Membership Tracker
Scenario

A modern gym offers several membership plans to customers with different fitness goals. The gym manager wants a console application to help employees manage memberships and encourage consistent attendance.

The gym tracks:

How often members visit
Membership type
Reward eligibility
Active/inactive members

Members who attend frequently can qualify for free rewards like smoothies or protein shakes. Premium members also pay higher monthly fees but receive additional benefits.

The gym recently introduced a “Consistency Challenge.” If a member’s monthly visits meet certain mathematical conditions, they earn rewards automatically.

The owner also wants the system to:

Prevent invalid ages
Prevent unrealistic visit counts
Count how many VIP members exist
Identify the most active gym member
Detailed Instructions
Create an enum
enum MembershipType
{
    Basic,
    Premium,
    VIP
}
Create a GymMember class
Properties
MemberName
Age
MembershipType
MonthlyVisits
MonthlyFee
Constraints
Age must be between 16–65
Visits must be between 0–60
Methods
CalculateMembershipFee()
Basic → $25
Premium → $45
VIP → $80
CheckRewardEligibility()

If visits are divisible by 10:

MonthlyVisits % 10 == 0

The member receives a free protein shake.

DetermineActivityStatus()

Use a ternary operator:

20+ visits → "Active"
Otherwise → "Inactive"
DisplayMemberInfo()

Display all member information and rewards.

In Main()
Create at least 6 members
Display all membership information
Count VIP members
Find the member with the highest visits