using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Func<double, double, double> add = (a, b) => a + b;
        Console.WriteLine($"The sum of {num1} + {num2} is {add(num1, num2)}");

        Func<double, double, double> multiply = (a, b) => a * b;
        Console.WriteLine($"The product of {num1} x {num2} is {multiply(num1, num2)}");

        Func<double, double, double> compare = (a, b) => a < b ? a : b;
        Console.WriteLine($"The smaller value between {num1} and {num2} is {compare(num1, num2)}");
    }
}
