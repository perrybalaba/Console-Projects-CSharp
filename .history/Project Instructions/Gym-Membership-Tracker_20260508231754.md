# 2. Smart Gym Membership Tracker

## Scenario

A modern gym offers several membership plans to customers with different fitness goals. The gym manager wants a console application to help employees manage memberships and encourage consistent attendance.

**The gym tracks:**

- How often members visit
- Membership type
- Reward eligibility
- Active/inactive members

Members who attend frequently can qualify for free rewards like smoothies or protein shakes. Premium members also pay higher monthly fees but receive additional benefits.

The gym recently introduced a ***“Consistency Challenge.”*** If a member’s monthly visits meet certain mathematical conditions, they earn rewards automatically.

**The owner also wants the system to:**

- Prevent invalid ages
- Prevent unrealistic visit counts
- Count how many VIP members exist
- Identify the most active gym member

## Detailed Instructions

### Create an enum:

```C#
enum MembershipType
{
    Basic,
    Premium,
    VIP
}
```

### Create a `GymMember` class

**Properties:**
- MemberName
- Age
- MembershipType
- Visits
- MonthlyFee

**Constraints:**
- Age must be between 16–65
- Visits must be between 0–60

**Methods:**

`CalculateMembershipFee()`
- Basic → $25
- Premium → $45
- VIP → $80

`CheckRewardEligibility()`

If visits are divisible by 10:

```C#
MonthlyVisits % 10 == 0
```
The member receives a free protein shake.

`DetermineActivityStatus()`

Use a ternary operator:

- 20+ visits → "Active"
- Otherwise → "Inactive"

`DisplayMemberInfo()`

Display all member information and rewards.

### In Main()
- Create at least 6 members
- Display all membership information
- Count VIP members
- Find the member with the highest visits

## Sample Input

```
Member 1
Name: Daniel Smith
Age: 22
Membership Type: Premium
Monthly Visits: 20

Member 2
Name: Olivia Johnson
Age: 31
Membership Type: VIP
Monthly Visits: 17

Member 3
Name: Jason Miller
Age: 19
Membership Type: Basic
Monthly Visits: 30
```

## Expected Output
```
--- GYM MEMBER INFORMATION ---

Member: Daniel Smith
Age: 22
Membership: Premium
Monthly Fee: $45
Visits: 20
Reward Earned: Free Protein Shake
Status: Active

--------------------------------

Member: Olivia Johnson
Age: 31
Membership: VIP
Monthly Fee: $80
Visits: 17
Reward Earned: None
Status: Inactive

--------------------------------

Member: Jason Miller
Age: 19
Membership: Basic
Monthly Fee: $25
Visits: 30
Reward Earned: Free Protein Shake
Status: Active

--------------------------------

Total VIP Members: 1

Most Active Member:
Jason Miller with 30 visits
```

## My Code to the Project
### Gym Membership Tracker
[C# (Class)](../Gym-Membership-Tracker/GymMember.cs) |
[C# (Main)](../Gym-Membership-Tracker/Program.cs)