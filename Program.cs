using System;
using System.Globalization;
class Program {
    public static void Main(string[] args)
    {
    double num1;
    double num3;
    double num2;
    double result;

    Console.Write("Enter 1st number ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter 2nd number ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter 3rd number ");
    num3 = Convert.ToDouble(Console.ReadLine());

    result = num1 + num2 + num3;
    Console.WriteLine($"Addition of three number {num1} + {num2} + {num3} = {result:F6}");

    result = num1 - num2 - num3;
    Console.WriteLine($"Subtraction of three number {num1} - {num2} - {num3} = {result:F6}");

    result = num1 * num2 * num3;
    Console.WriteLine($"Multiplication of three number {num1} * {num2} * {num3} = {result:F6}");

    result = num1 / num2 / num3;
    Console.WriteLine($"Division of three number {num1} / {num2} / {num3} = {result:F6}");

    result = num1 % num2 % num3;
    Console.WriteLine($"Remainder of three number {num1} % {num2} % {num3} = {result:F6}");

    result = (num1 + num2 + num3) / 3;
    Console.WriteLine($"Average of three number {num1} % {num2} % {num3} = {result:F6}");
    }
}