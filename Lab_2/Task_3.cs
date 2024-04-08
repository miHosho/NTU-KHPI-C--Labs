/*using System;
using System.Collections.Generic;

class Task_3
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<int> arr = new List<int>(); // Динамический массив

        Console.Write("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        {
            Random random = new Random();

            // Заполняем массив случайными числами от -100 до 100
            for (int i = 0; i < size; i++)
            {
                arr.Add(random.Next(-100, 101));
            }

            Console.WriteLine("Начальный массив:");
            PrintArray(arr);

            // Вычисление среднего значения положительных чисел
            double positiveSum = 0;
            int positiveCount = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    positiveSum += item;
                    positiveCount++;
                }
            }

            double average = positiveCount > 0 ? positiveSum / positiveCount : 0;
            Console.WriteLine("Массив-результат:");
            // Заменяем отрицательные элементы средним арифметическим значением положительных элементов
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Задаем красный цвет для отрицательных чисел
                    arr[i] = (int)average;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Задаем зеленый цвет для положительных чисел
                }

                Console.Write($"{arr[i],3} ");
                Console.ResetColor(); // Сброс цвета для следующего элемента
            }


        }
        else
        {
            Console.WriteLine("Некорректный размер массива.");
        }

        Console.ReadKey();
    }

    static void PrintArray(List<int> arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item,3} ");
        }
        Console.WriteLine();
    }
}
*/