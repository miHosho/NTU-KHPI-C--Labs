/*using System;

class Task_5
{
    static void Main()
    {
        const int N = 9; // Размер матрицы

        int[,] matrix = new int[N, N];
        Random random = new Random();

        // Заполняем матрицу случайными числами
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(0, 100);
            }
        }

        // Отображаем симметричные секторы
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Console.WriteLine("\nСимметричные секторы:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i < j && i + j < N - 1 || i > j && i + j > N - 1 || i == j || i + j == N - 1) Console.Write($"{matrix[i, j],3}");

                else Console.Write($"{matrix[i, N - 1 - j],3}");
            }

            Console.WriteLine();
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