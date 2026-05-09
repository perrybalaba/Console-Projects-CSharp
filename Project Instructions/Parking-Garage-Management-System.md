# 1. Parking Garage Management System

## Scenario

A large parking garage located in downtown Montreal serves office workers, tourists, and delivery drivers every day. Because the garage is located near shopping centers and business offices, different types of vehicles enter and leave constantly throughout the day.

The parking company wants a small console application to help attendants manage vehicle parking information. The system should track how long vehicles stay parked, calculate parking fees depending on vehicle type, and apply special discounts during promotions.

**The garage has strict rules:**

- Vehicles cannot stay longer than 24 hours
- Trucks pay higher fees because they take more space
- Some customers receive discounts if their parking duration matches promotional conditions
- Parking attendants need to quickly identify overloaded parking situations

**The company also wants to analyze:**

- How many trucks entered the garage
- Which customer paid the highest parking fee
- Which vehicles qualified for discounts

## Detailed Instructions

### Create an enum:

```C#
enum VehicleType
{
    Car,
    Motorcycle,
    Truck
} 
```
### Create a `Vehicle` class:

**Include:**
- Private fields
- Public properties
- Default constructor
- Parameterized constructor

**Properties:**
- LicensePlate
- OwnerName
- HoursParked
- VehicleType
- ParkingFee

**Methods:**

`CalculateParkingFee()`

Calculate fees:

- Car → $4/hour
- Motorcycle → $2/hour
- Truck → $6/hour

`ValidateParkingDuration()`

Rules:

- Minimum = 1 hour
- Maximum = 24 hours
- Invalid hours should display an error

`ApplySpecialPromotion()`

If parked hours are divisible by 5:

``` C#
HoursParked % 5 == 0
```

- Apply a 15% discount.

`DisplayVehicleInfo()`

Display:

- Owner
- Vehicle type
- Hours parked
- Final fee

### In Main()

- Create at least 5 vehicles
- Store them in an array or list
- Display all parking details
- Count total trucks
- Find the vehicle with the highest parking fee

### Sample Input
**Vehicle 1**
``` 
Owner Name: Sarah Lee
License Plate: ABC123
Vehicle Type: Car
Hours Parked: 5
```

**Vehicle 2**
```
Owner Name: Mike Brown
License Plate: TRK900
Vehicle Type: Truck
Hours Parked: 12
```

***Vehicle 3***
```
Owner Name: Emma Wilson
License Plate: MOTO77
Vehicle Type: Motorcycle
Hours Parked: 7
```

### Expected Output 
```
--- VEHICLE INFORMATION ---

Owner: Sarah Lee
Vehicle Type: Car
Hours Parked: 5
Base Fee: $20
Promotion Applied: YES
Discount: 15%
Final Parking Fee: $17

--------------------------------

Owner: Mike Brown
Vehicle Type: Truck
Hours Parked: 12
Base Fee: $72
Promotion Applied: NO
Final Parking Fee: $72

--------------------------------

Owner: Emma Wilson
Vehicle Type: Motorcycle
Hours Parked: 7
Base Fee: $14
Promotion Applied: NO
Final Parking Fee: $14

--------------------------------

Total Trucks Parked: 1

Highest Parking Fee:
Mike Brown - $72
```

## My Code
[My Parking Garage Management System in C#](./Parking-Garage-Management-System/Parking-Garage-Management-System.sln)