/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task_8
{
    static void Main()
    {
        long n;         // кол-во значений ряда
        double sum = 0;     // сумма членов ряда
        double term = 0;    // значение текущего члена
        double eps;  // предел точности
        long k2 = 1;        // Math.Pow(2, n)
        short k1 = 1;       // Math.Pow(-1, n)

        Console.Write("Введите погрешность (например: 0,000001) и количество членов ряда > ");
        string input = Console.ReadLine();
        string[] inputParts = input.Split(' ');
        eps = double.Parse(inputParts[0]);
        n = int.Parse(inputParts[1]);

        // Основной цикл; в модификациях вычисляются следующие значения Math.Pow(2, n) и Math.Pow(-1, n)
        for (long i = 0; i <= n; i++, k2 *= 2, k1 = (short)-k1)
        {

            // Вычисление очередного члена
            term = k1 * (1 - k2 / (k2 + 1));

            // Проверка достижения предела точности
            if (Math.Abs(term) >= eps)
            {
                // Если не достигнут - накопление суммы
                sum += term;
            }
            else
            {
                // Вывод суммы ряда по достижению погрешности
                Console.WriteLine($"Сумма членов ряда достигла заданной погрешности. Сумма {i} членов ряда = {sum:F7}");
                break; // Если достигнут - выход из цикла
            }

            // Вывод суммы ряда по заданному количеству
            if (i == n)
            {
                Console.WriteLine($"Сумма {n} членов ряда = {sum:F7}");
            }
        }



        Console.ReadKey();

    }
}

*/