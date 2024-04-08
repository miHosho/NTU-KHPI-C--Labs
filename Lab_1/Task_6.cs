/*using System;

class Task_6
{
    static void Main()
    {
        double x, y; // координаты точки

        // ввод координат
        Console.Write("Введите координату x > ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату y > ");
        y = double.Parse(Console.ReadLine());

        // вывод только что введенных значений
        Console.WriteLine($"x = {x:F3};  y = {y:F3}");

        // Проверка условий и вывод результата
        string resultMessage = IsPointInCircleWithCutout(x, y) ? "Точка попадает в область" : "Точка не попадает в область";
        Console.WriteLine(resultMessage);

        Console.ReadKey();
    }

    // Функция для проверки, находится ли точка (x, y) в круге с вырезанной нижней правой четвертью
    static bool IsPointInCircleWithCutout(double x, double y)
    {
        // Уравнение круга с радиусом в единицу и центром в начале координат
        bool isInCircle = (x * x + y * y) <= 1;

        // Вырезание нижней правой четверти
        bool isCutout = x >= 0 && y <= 0;

        // Если точка находится в круге и не в вырезанной четверти, вернуть true
        return isInCircle && !isCutout;
    }
}
*/