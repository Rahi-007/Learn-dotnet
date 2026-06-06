using System;
using System.Collections.Immutable;

class Program
{
    public static void Main(string[] args)
    {
        // Add Two Numbers =>
        Console.WriteLine($"Add Two Numbers => {string.Join(", ", AddTwoNumbers([2,3,4], [3,5,3]))}");
        Console.ReadKey();
    }
    public static int[] AddTwoNumbers(int[] l1, int[] l2) {
        Array.Reverse(l1);
        Array.Reverse(l2);
        Console.WriteLine(string.Join(", ", l1));
        Console.WriteLine(string.Join(", ", l2));
        return [];
    }
}