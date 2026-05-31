using System;

class Person
{
    private readonly string name = "";
    private readonly int age = 0;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.Write($"Name: {this.name}, \n age: {this.age} \n");
    }

    public int Age
    {
        set;
        get;
    }

    public string Name
    {
        set;
        get;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        new Person("Rahi", 20);
    }
}