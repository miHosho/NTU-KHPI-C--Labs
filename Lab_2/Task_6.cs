/*using System;

class Task_6
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
        {
            Console.Write("Введите количество столбцов матрицы: ");
            if (int.TryParse(Console.ReadLine(), out int cols) && cols > 0)
            {
                int[,] matrix = new int[rows, cols];
                Random random = new Random();

                // Заполняем матрицу случайными числами
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = random.Next(0, 100);
                    }
                }

                // Отображаем симметричные секторы
                Console.WriteLine("Исходная матрица:");
                PrintMatrix(matrix);

                Console.WriteLine("\nСимметричные секторы:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i < j && i + j < rows - 1 || i > j && i + j > rows - 1 || i == j || i + j == rows - 1)
                            Console.Write($"{matrix[i, j],3}");
                        else
                            Console.Write($"{matrix[i, cols - 1 - j],3}");
                    }

                    Console.WriteLine();
                }
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

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],3}");
            }
            Console.WriteLine();
        }
    }
}
*/