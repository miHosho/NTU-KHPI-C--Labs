/*using System;

class Task_9
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
        {
            Console.Write("Введите количество столбцов матрицы: ");
            if (int.TryParse(Console.ReadLine(), out int cols) && cols > 0)
            {
                int[][] matrix = new int[rows][];
                Random random = new Random();

                // Инициализируем зубчатый массив
                for (int i = 0; i < rows; i++)
                {
                    matrix[i] = new int[cols];
                }

                // Заполняем матрицу случайными числами от -50 до 50
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i][j] = random.Next(-50, 51);
                    }
                }

                // Отображаем матрицу
                Console.WriteLine("Матрица:");
                PrintMatrix(matrix);

                int sum = 0;

                // Находим сумму элементов в столбцах, содержащих хотя бы один отрицательный элемент
                for (int j = 0; j < cols; j++)
                {
                    bool hasNegative = false;

                    for (int i = 0; i < rows; i++)
                    {
                        if (matrix[i][j] < 0)
                        {
                            hasNegative = true;
                            break;
                        }
                    }

                    if (hasNegative)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            sum += matrix[i][j];
                        }
                    }
                }

                Console.WriteLine($"Сумма элементов в столбцах, содержащих хотя бы один отрицательный элемент: {sum}");
            }
            else
            {
                Console.WriteLine("Некорректное количество столбцов.");
            }
        }
        else
        {
            Console.WriteLine("Некорректное количество строк.");
        }

        Console.ReadLine();
    }

    static void PrintMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        for (int i = 0; i < rows; i++)
        {
            int cols = matrix[i].Length;
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i][j],3}");
            }
            Console.WriteLine();
        }
    }
}
*/