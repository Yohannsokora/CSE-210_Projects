using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // while loop # 1
        int count = 5;

        while(count < 10){
            //same as the one down
            System.Console.WriteLine($"Count = {count++}");
 
        }
        //while loop number # 2
        while(count<15)
        {
            System.Console.WriteLine($"Count = {count}");
            count++;

        }
        // Do while loop; ++ at the beginning will increment the value before it is returned and vis versa.
        int anotherCount = 0;
        do{
            System.Console.WriteLine($"AnotherCount = {++anotherCount}");
        }while (anotherCount < 10);

        // For loop
        for(int i=0; i<5; i++){
            System.Console.WriteLine($"i={i}");
        }

        // Guess my number Assignment
        int guess = -1;
        bool iscorrect = false;

        // Ask for random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        // Ask for user guess
        System.Console.WriteLine($"Guess a random number");
        int guess = int.Parse(Console.ReadLine());

        // Check if number is higher
        if(guess > number){
            System.Console.WriteLine($"Too High!");
        }
        // Check if number is Lower
        else if (guess < number){
            System.Console.WriteLine($"Too low!");
        }
        // Check if guess match
        else
            System.Console.WriteLine($"Congratulation you found it!");

        // Keep going

    
    }
}