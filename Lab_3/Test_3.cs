/*using System;
using System.Text;

class Task_3
{
    static void Main()
    {
        Console.Write("Введите текстовую строку: ");
        string input = Console.ReadLine();

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

        Console.WriteLine("Результат:");
        Console.WriteLine(result.ToString());
        Console.ReadKey();
    }
}
*/