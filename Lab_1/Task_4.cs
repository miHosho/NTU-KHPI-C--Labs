/*using System;

class Task_4
{
    static void Main()
    {
        double x;
        double a = 12.5, b = 1.3;
        double t1 = 0, t2 = 0;
        double ax;
        int test;

        bool isCorrect = false;

        do
        {
            Console.Write("Введите число x > ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out x))
            {
                isCorrect = true;
                ax = a * x;

                try
                {
                    if (x < 0)
                    {
                        throw new Exception("Ошибка: Попытка получить логарифм из отрицательного числа.");
                        isCorrect = false;
                    }
                    test = (int)Math.Pow(b, 3) / (int)x;
                    test = 1 / (int)(1 - Math.Sin(ax));
                    t1 = (Math.Pow(x, 3) / 3 - 3 * b * x + 3 * Math.Pow(b, 2) * Math.Log(x) + Math.Pow(b, 3) / x) / Math.Pow(a, 4);
                    t2 = 1 / (1 - Math.Sin(ax)) + Math.Tan(ax / 2) / a;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                    isCorrect = false;
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные. Пожалуйста, введите одно число.");
            }

        } while (!isCorrect);
        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");
        Console.ReadKey();
    }
}
*/