using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;

        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number){
                Console.WriteLine("Too high!");
            }
            else if (guess < number){
                Console.WriteLine("Too Low!");

            }
            else{
                Console.WriteLine("Congratulation! You guessed right!");
            }
        }
    }
}