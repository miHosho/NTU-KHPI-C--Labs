/*using System;

class Task_1
{
    static void Main()
    {
        int[] array = new int[100]; // Создаем массив

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 101); // Заполняем массив случайными числами от -100 до 100
        }

        Console.WriteLine("Начальный массив:");
        PrintArray(array);

        int sumPositive = 0; // Сумма положительных элементов
        int countPositive = 0; // Количество положительных элементов

        // Находим сумму положительных элементов и их количество
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sumPositive += array[i];
                countPositive++;
            }
        }

        if (countPositive > 0)
        {
            int averagePositive = sumPositive / countPositive; // Среднее арифметическое положительных элементов

            // Заменяем отрицательные элементы средним арифметическим значением положительных элементов
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = averagePositive;
                }
            }
        }

        Console.WriteLine("Массив-результат:");
        PrintArray(array);

        Console.ReadKey();
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item,3} ");
        }
        Console.WriteLine();
    }
}
*/