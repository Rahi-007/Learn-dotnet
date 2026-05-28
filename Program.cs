using System;
class Program
{
    public static void Main()
    {
        double value, value2;
        bool result;

        Console.WriteLine("Compare 2 numbers");
        Console.Write("Enter The 1st number");
        value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter The 2nd number");
        value2 = Convert.ToDouble(Console.ReadLine());

        result = value >= value2;
        Console.WriteLine($"{value} >= {value2} = {value >= value2}");
    }
}