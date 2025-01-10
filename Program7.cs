using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the desired accuracy (epsilon): ");
        double epsilon = double.Parse(Console.ReadLine());

        Console.WriteLine($"Approximated value of π: {CalculatePi(epsilon) * 4:F10}");

        Console.Write("Enter x (in radians) for sin(x) and cos(x): ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Approximated value of sin(x): {CalculateSin(x, epsilon):F10}");
        Console.WriteLine($"Approximated value of cos(x): {CalculateCos(x, epsilon):F10}");

        Console.Write("Enter x for ln(1+x): ");
        double lnX = double.Parse(Console.ReadLine());
        Console.WriteLine($"Approximated value of ln(1+x): {CalculateLn(lnX, epsilon):F10}");
    }

    static double CalculatePi(double epsilon)
    {
        double sum = 0;
        int n = 0;

        while (true)
        {
            double term = Math.Pow(-1, n) / (2 * n + 1);
            if (Math.Abs(term) < epsilon)
                break;

            sum += term;
            n++;
        }

        return sum;
    }

    static double CalculateSin(double x, double epsilon)
    {
        double sum = 0;
        int n = 0;

        while (true)
        {
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
            if (Math.Abs(term) < epsilon)
                break;

            sum += term;
            n++;
        }

        return sum;
    }

    static double CalculateCos(double x, double epsilon)
    {
        double sum = 1;
        int n = 1;

        while (true)
        {
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
            if (Math.Abs(term) < epsilon)
                break;

            sum += term;
            n++;
        }

        return sum;
    }

    static double CalculateLn(double x, double epsilon)
    {
        if (x <= -1)
        {
            Console.WriteLine("ln(1+x) is undefined for x <= -1.");
            return double.NaN;
        }

        double sum = 0;
        int n = 1;

        while (true)
        {
            double term = Math.Pow(-1, n - 1) * Math.Pow(x, n) / n;
            if (Math.Abs(term) < epsilon)
                break;

            sum += term;
            n++;
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
