using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is your grade in percentage?: ");
      string GradeInPercentage = Console.ReadLine();
      int grade = int.Parse(GradeInPercentage);

      string letter;

      if (grade >= 90){
        letter = "A";
      }
      else if (grade >= 80 && grade < 90){
       letter = "B";
      }
      else if (grade >= 70 && grade < 80){
        letter = "C";
      }
      else if (grade >= 60 && grade < 70){
        letter = "D";
      }
      else{
        letter = "F";
      }
      Console.WriteLine($"{letter}");
      if (grade >= 70){
        Console.WriteLine("Congratulation, You passed the class!");
      }
      else{
        Console.WriteLine("Unfortunately, you failed the class. Keep pushing!");
      }

    }
} 