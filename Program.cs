using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"S1 = {CalculateS1(n):F5}");
        Console.WriteLine($"S2 = {CalculateS2(n):F5}");
        Console.WriteLine($"S5 = {CalculateS5(n):F5}");
        Console.WriteLine($"S6 = {CalculateS6(n):F5}");
        Console.WriteLine($"S7 = {CalculateS7(n):F5}");
    }

    static double CalculateS1(int n)
    {
        double sum = 1;
        double denominator = 0;

        for (int i = 1; i <= n; i++)
        {
            denominator += i * i;
            sum -= Math.Pow(-1, i - 1) / denominator;
        }

        return sum;
    }

    static double CalculateS2(int n)
    {
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(-2, i) / Factorial(i);
        }

        return sum;
    }

    static double CalculateS5(int n)
    {
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(-1, i + 1) / (2 * i);
        }

        return sum;
    }

    static double CalculateS6(int n)
    {
        double sum = 1;
        double denominator = 0;

        for (int i = 1; i <= n; i++)
        {
            denominator += i;
            sum += Math.Pow(-1, i) / denominator;
        }

        return sum;
    }

    static double CalculateS7(int n)
    {
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(2, i) / Factorial(i);
        }

        return sum;
    }

    static double Factorial(int number)
    {
        double result = 1;

        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}



