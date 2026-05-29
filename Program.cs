using System;
class Program
{
    public static void Main(string[] args)
    {
        double mark;

        Console.Write("Enter Your Mark: ");
        mark = Convert.ToInt32(Console.ReadLine());

        if (mark > 0 && mark < 100)
        {
            char grade;
            if (mark >= 90)
            {
                grade = 'A';
            }
            else if (mark >= 80)
            {
                grade = 'B';
            }
            else if (mark >= 70)
            {
                grade = 'C';
            }
            else if (mark >= 60)
            {
                grade = 'D';
            }
            else if (mark >= 50)
            {
                grade = 'E';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine($"You got {grade}");
        }
        else
        {
            Console.WriteLine($"{mark} is Invalid");
        }
    }
}