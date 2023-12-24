using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        int var1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");

        int var2 = int.Parse(Console.ReadLine());

        int sum = var1 + var2;

        Console.WriteLine("Sum is" + " " + sum);


    }

}