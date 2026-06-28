using System;

class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine($"Add Two Numbers => {string.Join(", ", AddTwoNumbers([2, 3, 4, 4], [3, 5, 3]))}");
        Console.ReadKey();
    }

}