using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        string? input = Console.ReadLine();

        if (!double.TryParse(input, out double n))
        {
            Console.WriteLine("Некоректне число");
            return;
        }

        Predicate<double> isPositive = x => x > 0;

        Console.WriteLine(isPositive(n)
            ? "Число є додатним"
            : "Число НЕ є додатним");
    }
}
