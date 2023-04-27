using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine(first_name);

        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine(last_name);

        Console.WriteLine($"Your full name is: {first_name} {last_name}");
    }
}