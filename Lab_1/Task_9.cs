/*using System;

class Task_9
{
    static void Main()
    {
        short n;        // параметр внешнего цикла
        double x = 0, y = 0;    // абсцисса и ордината графика
        short h;        // позиция точки на экране
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
                // Если n четное, инвертируем y
                //if (n % 2 != 0) y = -y;

                // вывод строки таблицы
                Console.Write($"| {x + n * 4,5:F2} | {y,10:F7} |");

                // определение позиции точки
                h = (short)((y + 1) * 10);
                if (y - 1 - h * 10 > 0.5) h++;

                // вывод точки графика
                for (; h > 0; h--) Console.Write(" ");
                Console.WriteLine("*");
            }  // конец внутреннего цикла

            // пауза до команды оператора


        }  // конец внешнего цикла
        Console.WriteLine("Нажмите клавишу Enter для выхода...");
        Console.ReadLine();
    }
}
*/