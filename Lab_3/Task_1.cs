/*using System;

class Task_1
{
    static string RemoveSubstring(string input, int startIndex, int length)
    {
        if (startIndex < 0 || startIndex >= input.Length || length <= 0)
        {
            // Некорректные параметры
            return input;
        }

        if (startIndex + length >= input.Length)
        {
            // Если начальная позиция и длина превышают длину строки, вернуть пустую строку
            return string.Empty;
        }

        // Удалить подстроку, используя метод Remove
        string result = input.Remove(startIndex, length);
        return result;
    }

    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Console.Write("Введите начальную позицию: ");
        if (!int.TryParse(Console.ReadLine(), out int startIndex))
        {
            Console.WriteLine("Некорректная начальная позиция.");
            return;
        }

        Console.Write("Введите длину подстроки для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int length))
        {
            Console.WriteLine("Некорректная длина.");
            return;
        }

        string result = RemoveSubstring(input, startIndex, length);
        Console.WriteLine($"Результат: {result}");
        Console.ReadKey();
    }
}
*/