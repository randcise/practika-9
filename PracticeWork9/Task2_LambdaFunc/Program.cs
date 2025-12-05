using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть a: ");
        string? sa = Console.ReadLine();
        Console.Write("Введіть b: ");
        string? sb = Console.ReadLine();
        Console.Write("Введіть c: ");
        string? sc = Console.ReadLine();

        if (!double.TryParse(sa, out double a) ||
            !double.TryParse(sb, out double b) ||
            !double.TryParse(sc, out double c))
        {
            Console.WriteLine("Некоректні дані");
            return;
        }

        Func<double, double> func = x => a * x * x + b * x + c;

        for (double x = 0; x <= 10; x++)
        {
            Console.WriteLine($"x={x}, y={func(x)}");
        }
    }
}
