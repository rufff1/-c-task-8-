using System;

namespace task3
{

    public class Task3
    {
        static void Main()
        {

            Addition addition = new Addition();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();
            Division division = new Division();

            //Console.WriteLine(addition.Operate(10, 5));
            //Console.WriteLine(substraction.Operate(10,5));
            //Console.WriteLine(multiplication.Operate(10,5));
            //Console.WriteLine(division.Operate(10,5));


            Console.WriteLine($" Addition       : First number = {10}, Second number = {5} . Result = {addition.Operate(10, 5)} ");
            Console.WriteLine($" Substraction   : First number = {10}, Second number = {10}. Result = {substraction.Operate(10,10)} ");
            Console.WriteLine($" Multiplication : First number = {20}, Second number = {30}. Result = {multiplication.Operate(10, 5)}");
            Console.WriteLine($" Division       : First number = {60}, Second number = {20}. Result = {division.Operate(10, 5)}");



        }
    }
}