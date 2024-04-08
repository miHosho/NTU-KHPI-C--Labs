
/*
using System;

class Task_10
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Установка кодировки UTF-8

        short n;        // параметр внешнего цикла
        double x = 0, y = 0;    // абсцисса и ордината графика
        short h;        // позиция точки на экране
        Console.ForegroundColor = ConsoleColor.Red; // Цвет для чисел
        Console.WriteLine("|   x   |      y     |");
        Console.WriteLine("|-------|------------|");
        // внешний цикл - для 5 периодов
        for (n = 0; n < 5; n++)
        {
            // вывод заголовка таблицы

            // внутренний цикл для одного периода
            for (x = 0; x < 4; x += 0.25)
            {
                // Вычисление значения y
                if (x < 2)
                {
                    y = Math.Sqrt(1 - Math.Pow(x - 1, 2));
                }
                else
                {
                    y = Math.Sqrt(1 - Math.Pow(x - 3, 2));
                    y = -y;
                }
                if (x + n * 4.5 >= 21.1) break;

                // Установка цветов для чисел, текста и графика
                Console.ForegroundColor = ConsoleColor.Yellow; // Цвет для чисел
                Console.Write($"| {x + n * 4,5:F2} | {y,10:F7} |");
                Console.ResetColor(); // Сброс цвета

                // определение позиции точки
                h = (short)((y + 1) * 10);
                string name = "⸺";
                string name1 = "⸜";
                string name2 = "⸝";
                string name3 = "\\";
                string name4 = "/";
                string name5 = "|";

                // Установка цвета для графика
                Console.ForegroundColor = ConsoleColor.Green;
                if (h == 10) Console.WriteLine($"{name,10}");
                if (h == 16 && x < 1) Console.WriteLine($"{name1,16}");
                else if (h == 16 && x > 1) Console.WriteLine($"{name2,16}");
                if (h == 18 && x < 1) Console.WriteLine($"{name1,18}");
                else if (h == 18 && x > 1) Console.WriteLine($"{name2,18}");
                if (h == 19 && x < 1) Console.WriteLine($"{name3,19}");
                else if (h == 19 && x > 1) Console.WriteLine($"{name4,19}");
                if (h == 3 && x < 3) Console.WriteLine($"{name2,5}");
                else if (h == 3 && x > 3) Console.WriteLine($"{name1,5}");
                if (h == 1 && x < 3) Console.WriteLine($"{name2,3}");
                else if (h == 1 && x > 3) Console.WriteLine($"{name1,3}");
                if (h == 0 && y == -1) Console.WriteLine($"{name5,0}");
                else if (h == 0 && x < 3) Console.WriteLine($"{name4,2}");
                else if (h == 0 && x > 3) Console.WriteLine($"{name3,2}");
                if (h == 20) Console.WriteLine($"{name5,20}");
                Console.ResetColor(); // Сброс цвета
            }  // конец внутреннего цикла
        }  // конец внешнего цикла
        Console.ForegroundColor = ConsoleColor.Blue; // Цвет для чисел
        Console.WriteLine("Нажмите клавишу Enter для выхода...");
        Console.ReadLine();
    }
}
*/