using System;

class Motorcycle
{
    private string model;
    private int? passengerCapacity;
    private double fuelСapacity;
    private readonly double maxSpeed;
    private bool isThePlaneFlying;
    public Motorcycle(string model, int? passengerCapacity, double fuelСapacity, double maxSpeed)
    {
        this.model = model;
        this.passengerCapacity = passengerCapacity;
        this.fuelСapacity = fuelСapacity;
        this.maxSpeed = maxSpeed;
        isThePlaneFlying = false;
    }
    public Motorcycle(string model, double fuelСapacity, double maxSpeed) : this(model, null, fuelСapacity, maxSpeed)
    {
        //this for an explicit constructor call
    }
    public string GetModel()
    {
        return model;
    }
    public int? GetPassengerCapacity()
    {
        return passengerCapacity;
    }
    public void SetPassengerCapacity(int? passengerCapacity)
    {
        this.passengerCapacity = passengerCapacity;
    }
    public double GetFuelCapacity()
    {
        return fuelСapacity;
    }
    public void SetFuelCapacity(double fuelСapacity)
    {
        this.fuelСapacity = fuelСapacity;
    }
    public double GetMaxSpeed()
    {
        return maxSpeed;
    }
    public void TakeOff()
    {
        if (isThePlaneFlying)
        {
            Console.WriteLine("The motorcycle is going now");
        }
        else
        {
            isThePlaneFlying = true;
            Console.WriteLine("The motorcycle starts");
        }
    }
    public void Landing()
    {
        if (isThePlaneFlying)
        {
            isThePlaneFlying = false;
            Console.WriteLine("The motorcycle stops");
        }
        else
        {
            Console.WriteLine("The motorcycle has already stops");
        }
    }
    public void Refueling(double amount)
    {
        fuelСapacity += amount;
        Console.WriteLine($"The motorcycle was filled with {amount} liters");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Motorcycle firstMotorcycle = new Motorcycle("Apache RTR 200 4V", 1, 12, 135);
        Console.WriteLine($"Model: {firstMotorcycle.GetModel()}");
        Console.WriteLine($"PassengerCapacity: {firstMotorcycle.GetPassengerCapacity()}");
        Console.WriteLine($"FuelСapacity: {firstMotorcycle.GetFuelCapacity()}");
        Console.WriteLine($"MaxSpeed: {firstMotorcycle.GetMaxSpeed()}");
        firstMotorcycle.TakeOff();
        firstMotorcycle.TakeOff();
        firstMotorcycle.TakeOff();
        firstMotorcycle.Landing();
        firstMotorcycle.Refueling(12);
        
        Console.WriteLine($"Updated capacity of people: {firstMotorcycle.GetPassengerCapacity()}");
    }
}