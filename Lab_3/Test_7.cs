/*using System;
using System.IO;
using System.Text;

class Task_7 //1
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
        // Чтение строки из файла
        string inputFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\input_1.txt";
        string input;

        try
        {
            input = File.ReadAllText(inputFilePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл с входными данными не найден.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return;
        }

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

        // Запись результата в файл
        string outputFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\output.txt";

        try
        {
            File.WriteAllText(outputFilePath, result);
            Console.WriteLine($"Результат успешно записан в файл {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при записи файла: {ex.Message}");
        }

        Console.ReadKey();
    }
}



class Task_7 //2
{
    static int FindFirstOccurrence(string input, string search)
    {
        // Используем метод IndexOf для поиска первого вхождения
        int index = input.IndexOf(search);

        // Возвращаем индекс первого вхождения, или -1, если подстрока не найдена
        return index;
    }

    static void Main()
    {
        // Чтение строки из файла
        string inputFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\input_1.txt";
        string input;

        try
        {
            input = File.ReadAllText(inputFilePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл с входными данными не найден.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return;
        }

        Console.Write("Введите подстроку для поиска: ");
        string search = Console.ReadLine();

        int result = FindFirstOccurrence(input, search);

        if (result != -1)
        {
            Console.WriteLine($"Первое вхождение подстроки \"{search}\" найдено на позиции {result}");
        }
        else
        {
            Console.WriteLine($"Подстрока \"{search}\" не найдена в строке.");
        }

        // Запись результата в файл
        string outputFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\output.txt";

        try
        {
            File.WriteAllBytes(outputFilePath, resu);
            Console.WriteLine($"Результат успешно записан в файл {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при записи файла: {ex.Message}");
        }

        Console.ReadKey();
    }
}


*//*class Task_3
{
    static void Main()
    {
        // Чтение текстовой строки из файла
        string inputFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\input_1.txt";
        string input;

        try
        {
            input = File.ReadAllText(inputFilePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл с входными данными не найден.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return;
        }

        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            // Добавляем текущий символ в результат
            result.Append(c);
            // Проверяем, является ли текущий символ буквой
            if (char.IsLetter(c))
            {
                // Если да, добавляем знак вопроса после него
                result.Append('?');
            }
        }

        // Запись результата в файл
        string outputFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\output.txt";

        try
        {
            File.WriteAllText(outputFilePath, result.ToString());
            Console.WriteLine($"Результат успешно записан в файл {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при записи файла: {ex.Message}");
        }

        Console.ReadKey();
    }
}*/