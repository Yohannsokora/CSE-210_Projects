using System;
using System.Runtime.CompilerServices;


public class Car{

    public int milesPerGallon;
    public int gallons;
    public string make;
    public string model;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        var cars = new List<Car>();


        var car = new Car();
        car.make = "Honda";
        car.model = "civic";
        car.gallons = 10;
        car.milesPerGallon = 30;

        // car = new Car()
        car.make = "Ford";
        car.model = "F-150";
        car.gallons = 30;
        car.milesPerGallon = 5;

        foreach


        
    }
}