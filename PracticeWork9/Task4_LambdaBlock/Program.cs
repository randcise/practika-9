using System;

class Program
{
    static void Main()
    {
        Console.Write("Скільки чисел Фібоначчі потрібно створити? ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n <= 0)
        {
            Console.WriteLine("Потрібно ввести додатне ціле число");
            return;
        }

        Func<int, int[]> fibonacci = count =>
        {
            int[] arr = new int[count];

            if (count >= 1) arr[0] = 0;
            if (count >= 2) arr[1] = 1;

            for (int i = 2; i < count; i++)
                arr[i] = arr[i - 1] + arr[i - 2];

            return arr;
        };

        int[] result = fibonacci(n);

        Console.WriteLine("Числа Фібоначчі:");
        foreach (int num in result)
            Console.Write(num + " ");
    }
}
