/*using System;

class Task_3
{
    static void Main()
    {
        double x;
        double a = 12.5, b = 1.3;
        double t1, t2;
        double ax;

        Console.Write("Введите число x > ");
        string input = Console.ReadLine();
        x = double.Parse(input);
        ax = a * x;

        t1 = (Math.Pow(x, 3) / 3 - 3 * b * x + 3 * Math.Pow(b, 2) * Math.Log(x) + Math.Pow(b, 3) / x) / Math.Pow(a, 4);
        t2 = 1 / (1 - Math.Sin(ax)) + Math.Tan(ax / 2) / a;

        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");
        Console.ReadKey();
    }
}
*/