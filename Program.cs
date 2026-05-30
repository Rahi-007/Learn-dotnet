using System;
class Program
{
    public static void Main(string[] args)
    {
        int num, num2;

        Console.Write("Enter 1st number: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(num, 2);
        string binary2 = Convert.ToString(num2, 2);
        Console.WriteLine($"Binary numbers: {binary}, {binary2}");

        int numAnd = num & num2;
        int numOr = num | num2;
        int numShift = num << num2;
        int numUnShift = num >> num2;
        Console.WriteLine($"bit And Operator number: {binary} & {binary2} = {Convert.ToString(numAnd, 2)}");
        Console.WriteLine($"bit Or Operator number: {binary} | {binary2} = {Convert.ToString(numOr, 2)}");
        Console.WriteLine($"bit Shift Operator number: {binary} << {binary2} = {Convert.ToString(numShift, 2)}");
        Console.WriteLine($"bit UnShift Operator number: {binary} >> {binary2} = {Convert.ToString(numUnShift, 2)}");

    }
}