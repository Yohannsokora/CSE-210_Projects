using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        //returnType FunctionName(ParameterTypeEncoder paramName1, ParameterTypeEncoder paramName2)
        //{
        //  FunctionName Body
        //}

        int Add2(int number){
            return number + 2;
        }
        int more = Add2(10);

        // return int

        // void

        void PrintName(string name){
            if (name.Length == 0){
                return;
            }
            System.Console.WriteLine($"Name is {name}");
            return;
        }

        // Variable scope

        var y = 0;{
            var w = 10;
            w = y + 4;
            y = w +5;
        }

    

    }
}