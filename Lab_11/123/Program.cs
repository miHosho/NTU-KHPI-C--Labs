using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "C:/Users/Public/source/repos/Lab_11/Task_7";
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Указанная директория не существует.");
                return;
            }

            string searchPattern = "*.cs";
            string searchText = "Task_6";
            string replaceText = "Task_7";

            string[] files = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    fileContent = fileContent.Replace(searchText, replaceText);
                    File.WriteAllText(filePath, fileContent, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при обработке файла {filePath}: {ex.Message}");
                }
            }

            Console.WriteLine("Замена завершена.");
        }
    }
