/*using System;

class Task_2
{
    static void Main()
    {
        int[] _year = new int[3];
        string[] name = new string[3];
        int[] diameter = new int[3];
        int[] frequency = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1}. Введите: Год, научного руководителя, диаметр антены, рабочую частоту > ");
            string input = Console.ReadLine();
            string[] inputParts = input.Split(' ');
            _year[i] = int.Parse(inputParts[0]);
            name[i] = inputParts[1];
            diameter[i] = int.Parse(inputParts[2]);
            frequency[i] = int.Parse(inputParts[3]);
        }
        //и (┐, ┌, ┘, └, ├, ┤, ┬, ┴
        Console.WriteLine("┌--------------------------------------------------------------------------┐");
        Console.WriteLine("| Проекты поиска внеземных сигналов                                        |");
        Console.WriteLine("├------┬----------------------┬--------------------┬-----------------------┤");
        Console.WriteLine("| Год  | Научный руководитель | Диаметр антены (м) | Рабочая частота (МГц) |");
        Console.WriteLine("├------|----------------------|--------------------|-----------------------┤");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"| {_year[i],-4} | {name[i],-20} | {diameter[i],-18} | {frequency[i],-21} |");
        }

        Console.WriteLine("├------┴----------------------┴--------------------┴-----------------------┤");
        Console.WriteLine("| Примечание: наблюдались объекты от 2 звезд до нескольких галактик        |");
        Console.WriteLine("└--------------------------------------------------------------------------┘");
        Console.ReadKey();
    }
}

*/