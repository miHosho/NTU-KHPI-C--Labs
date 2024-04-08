/*using System;

class Task_2
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
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

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
        Console.ReadKey();
    }
}

*/