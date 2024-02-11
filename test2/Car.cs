using System;

public class Car
{
    // Fields
    private string brand;
    private string model;
    private int year;

    // Properties
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 1900 && value <= DateTime.Now.Year)
                year = value;
            else
                throw new ArgumentException("Invalid year value");
        }
    }

    // Constructor
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Method
    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }

    public void Show()
    {
        Console.WriteLine("{");
        Console.WriteLine("\tBrand: " + brand);
        Console.WriteLine("\tModel: " + model);
        Console.WriteLine("\tYear: " + year);
        Console.Write("}");
    }
}

// Inheritance
public class ElectricCar : Car
{
    // Fields
    private int batteryCapacity;

    // Properties
    public int BatteryCapacity
    {
        get { return batteryCapacity; }
        set { batteryCapacity = value; }
    }

    // Constructor
    public ElectricCar(string brand, string model, int year, int batteryCapacity) : base(brand, model, year)
    {
        BatteryCapacity = batteryCapacity;
    }

    // Method overriding
    public override void StartEngine()
    {
        Console.WriteLine("Electric engine started!");
    }

    public override void Show()
    {
        Console.WriteLine("{");
        Console.WriteLine("\tBrand: " + brand);
        Console.WriteLine("\tModel: " + model);
        Console.WriteLine("\tYear: " + year);
        Console.WriteLine("\tBatteryCapacity: " + batteryCapacity);
        Console.Write("}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Encapsulation, Abstraction
        Car myCar = new Car("Toyota", "Corolla", 2022);
        Console.WriteLine($"My car: {myCar.Brand} {myCar.Model}, Year: {myCar.Year}");

        // Inheritance, Polymorphism
        ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2023, 100);
        myElectricCar.StartEngine(); // Polymorphism in action

        // Accessing properties
        myElectricCar.Brand = "Nio";
        Console.WriteLine($"My electric car: {myElectricCar.Brand} {myElectricCar.Model}, Year: {myElectricCar.Year}, Battery Capacity: {myElectricCar.BatteryCapacity}");
    }
}
