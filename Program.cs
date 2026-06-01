using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write($"Enter a Array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];

        // array input
        for (int index = 0; index < size; index++)
        {
            Console.Write($"{index + 1}. Enter: ");
            numbers[index] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write($"The array => ");

        // print array
        foreach (int num in numbers)
        {
            Console.Write($"{num}, ");
        }

        // find min and max
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (min > num)
            {
                min = num;
            }
            if (max < num)
            {
                max = num;
            }
        }

        // print max and min
        Console.WriteLine($"");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
    }
}