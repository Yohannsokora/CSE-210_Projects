using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

    // First way of creating list
    List<int> myInts = new List<int>();

    // Second way of creating list
    var moreInt = new List<int>();

    // Add number to the list.
    moreInt.Add(34);
    moreInt.Add(10);

    // Iterate over Items.
    foreach(var n in moreInt){
        System.Console.WriteLine($"n= {n}");
    }
    }
}