using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення x: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрібно було ввести число");
            return;
        }

        if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
        {
            Console.WriteLine("Некоректне число");
            return;
        }

        Func<double, double> positive = x => Math.Cos(x + 1);
        Func<double, double> nonPositive = x => 1 - 2 * Math.Sin(x);

        double result = x > 0 ? positive(x) : nonPositive(x);

        Console.WriteLine($"F({x}) = {result}");
    }
}
