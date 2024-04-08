/*using System;
using System.Collections.Generic;

// Базовый класс для плоских фигур
class Shape
{
    public double Area { get; protected set; }

    public Shape()
    {
        Area = 0.0;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Площадь фигуры: {Area}");
    }
}

// Класс для круга
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        CalculateArea();
    }

    private void CalculateArea()
    {
        Area = Math.PI * Math.Pow(Radius, 2);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Круг:");
        Console.WriteLine($"Радиус: {Radius}");
        base.DisplayInfo();
    }

    // Перегрузка оператора для изменения радиуса круга
    public static Circle operator +(Circle circle, double increment)
    {
        circle.Radius += increment;
        circle.CalculateArea();
        return circle;
    }
}

// Класс для квадрата
class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
        CalculateArea();
    }

    private void CalculateArea()
    {
        Area = Math.Pow(SideLength, 2);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Квадрат:");
        Console.WriteLine($"Длина стороны: {SideLength}");
        base.DisplayInfo();
    }

    // Перегрузка оператора для изменения длины стороны квадрата
    public static Square operator +(Square square, double increment)
    {
        square.SideLength += increment;
        square.CalculateArea();
        return square;
    }
}

// Класс для прямоугольника
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
        CalculateArea();
    }

    private void CalculateArea()
    {
        Area = Length * Width;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Прямоугольник:");
        Console.WriteLine($"Длина: {Length}");
        Console.WriteLine($"Ширина: {Width}");
        base.DisplayInfo();
    }

    // Перегрузка оператора для изменения длины или ширины прямоугольника
    public static Rectangle operator +(Rectangle rectangle, double increment)
    {
        rectangle.Length += increment;
        rectangle.Width += increment;
        rectangle.CalculateArea();
        return rectangle;
    }
}

class Program
{
    static void Main()
    {
        // Создаем массив фигур
        Shape[] shapes = new Shape[]
        {
            new Circle(5),
            new Square(4),
            new Rectangle(6, 8)
        };

        // Вывод информации о фигурах
        Console.WriteLine("Информация о фигурах:");
        Console.WriteLine("-------------------");
        foreach (var shape in shapes)
        {
            shape.DisplayInfo();
            Console.WriteLine("-------------------");
        }

        // Изменение радиуса круга с использованием перегруженного оператора
        Circle circle = (Circle)shapes[0];
        circle += 2.0;

        Console.WriteLine("Круг после изменения радиуса:");
        circle.DisplayInfo();

        // Сортировка массива фигур по площади (по возрастанию)
        Array.Sort(shapes, (x, y) => x.Area.CompareTo(y.Area));

        Console.WriteLine("Фигуры после сортировки по площади:");
        foreach (var shape in shapes)
        {
            shape.DisplayInfo();
            Console.WriteLine("-------------------");
        }

        Console.ReadKey();
    }
}
*/