/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task_7
{
    static void Main()
    {
        long n = 0;         // параметр ряда
        double dbln = 0;    // параметр ряда в форме с плавающей точкой
        double sum = 0;     // сумма членов ряда
        double term = 0;    // значение текущего члена
        const double eps = 0.000001;  // предел точности
        long k2 = 1;        // Math.Pow(2, n)
        short k1 = 1;       // Math.Pow(-1, n)

        // Основной цикл; в модификациях вычисляются следующие значения Math.Pow(2, n) и Math.Pow(-1, n)
        for (; ; n++, k2 *= 2, k1 = (short)-k1)
        {
            // Преобразование n в форму с плавающей точкой
            dbln = n;

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
                break; // Если достигнут - выход из цикла
            }

            // Если 10 членов - вывод суммы
            if (n == 9)
            {
                Console.WriteLine($"Сумма 10 членов ряда = {sum:F7}");
            }
        }

        // Вывод окончательной суммы
        Console.WriteLine($"Полная сумма ряда = {sum:F7}");
        Console.ReadKey();

    }
}

*/