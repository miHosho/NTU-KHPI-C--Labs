/*using System;
using System.Linq;
using System.Text.RegularExpressions;

class Task_6
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        // a) Подсчитываем количество цифр в тексте
        int digitCount = CountDigits(inputText);
        Console.WriteLine($"a) Количество цифр в тексте: {digitCount}");

        // b) Вывод слов, начинающихся с согласных букв
        MatchCollection matches = Regex.Matches(inputText, @"\b[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]\w*\b");
        string consonantWords = string.Join(", ", matches.Cast<Match>().Select(m => m.Value));
        Console.WriteLine($"b) Слова, начинающиеся с согласных букв: {consonantWords}");

        // c) Уничтожаем слова, начинающиеся и заканчивающиеся одной буквой
        string resultText = RemoveWordsWithSameStartAndEnd(inputText);
        Console.WriteLine($"c) Текст после удаления слов: {resultText}");
        Console.ReadKey();
    }

    static int CountDigits(string text)
    {
        int count = 0;
        foreach (char c in text)
        {
            if (char.IsDigit(c))
            {
                count++;
            }
        }
        return count;
    }

    static string RemoveWordsWithSameStartAndEnd(string text)
    {
        string[] words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length > 1 && char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
            {
                words[i] = string.Empty;
            }
        }

        return string.Join(" ", words);
    }
}
*/