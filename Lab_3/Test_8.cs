/*using System;
using System.IO;
using System.Text;

*//*class Task_8 //1
{
    static void Main()
    {
        Console.Write("Введите текстовую строку: ");
        string input = Console.ReadLine();

        // Заменяем все вхождения "не" на пустую строку
        string result = input.Replace("не", "");

        // Сохраняем результат в двоичный файл
        string binaryFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\output.dat"; 
        SaveToBinaryFile(binaryFilePath, result);

        // Читаем и выводим содержимое двоичного файла для проверки корректности
        string binaryContent = ReadBinaryFile(binaryFilePath);
        Console.WriteLine("Результат (из двоичного файла):");
        Console.WriteLine(binaryContent);

        Console.ReadKey();
    }

    static void SaveToBinaryFile(string filePath, string content)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(content);
        }
    }

    static string ReadBinaryFile(string filePath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            byte[] bytes = reader.ReadBytes((int)reader.BaseStream.Length);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}*//*


class Task_8 //2
{
    static void Main()
    {
        Console.Write("Введите текстовую строку: ");
        string input = Console.ReadLine();

        // Разбиваем строку на слова, разделитель - пробел
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Получаем общее количество слов
        int wordCount = words.Length;

        // Сохраняем результат (количество слов) в двоичный файл
        string binaryFilePath = "C:\\Users\\Vyacheslav\\source\\repos\\Lab_3\\word_count.dat";
        SaveToBinaryFile(binaryFilePath, wordCount);

        // Читаем и выводим содержимое двоичного файла для проверки корректности
        int readWordCount = ReadBinaryFile(binaryFilePath);
        Console.WriteLine("Общее количество слов (из двоичного файла): " + readWordCount);

        Console.ReadKey();
    }

    static void SaveToBinaryFile(string filePath, int value)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(value);
        }
    }

    static int ReadBinaryFile(string filePath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            return reader.ReadInt32();
        }
    }
}*/