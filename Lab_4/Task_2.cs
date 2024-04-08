using System;
using System.Collections.Generic;

// Интерфейс для медицинских объектов
interface IMedicalObject
{
    string Name { get; set; }
    void DisplayInfo();
}

// Класс пациента
class Patient : IMedicalObject
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Diagnosis { get; set; }

    public Patient(string name, int age, string diagnosis)
    {
        Name = name;
        Age = age;
        Diagnosis = diagnosis;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Пациент: {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Диагноз: {Diagnosis}");
    }
}

// Класс медицинского устройства
class MedicalDevice : IMedicalObject
{
    public string Name { get; set; }
    public string Description { get; set; }

    public MedicalDevice(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Медицинское устройство: {Name}");
        Console.WriteLine($"Описание: {Description}");
    }
}

// Класс физического медицинского устройства (унаследован от MedicalDevice)
class PhysicalMedicalDevice : MedicalDevice
{
    public double Weight { get; set; }
    public string Manufacturer { get; set; }

    public PhysicalMedicalDevice(string name, string description, double weight, string manufacturer)
        : base(name, description)
    {
        Weight = weight;
        Manufacturer = manufacturer;
    }

    public void DisplayAdditionalInfo()
    {
        Console.WriteLine($"Вес: {Weight} кг");
        Console.WriteLine($"Производитель: {Manufacturer}");
    }
}

class XRayMachine : PhysicalMedicalDevice
{
    public int MaxVoltage { get; set; }

    public XRayMachine(string name, string description, double weight, string manufacturer, int maxVoltage)
        : base(name, description, weight, manufacturer)
    {
        MaxVoltage = maxVoltage;
    }

    public void DisplayAdditionalInfo()
    {
        Console.WriteLine($"Максимальне напруга: {MaxVoltage} кВ");
    }
}


class MRIScanner : PhysicalMedicalDevice
{
    public string ImagingTechnology { get; set; }

    public MRIScanner(string name, string description, double weight, string manufacturer, string imagingTechnology)
        : base(name, description, weight, manufacturer)
    {
        ImagingTechnology = imagingTechnology;
    }

    public void DisplayAdditionalInfo()
    {
        Console.WriteLine($"Технологія зображення: {ImagingTechnology}");
    }
}


// Класс программного медицинского устройства (унаследован от MedicalDevice)
class SoftwareMedicalDevice : MedicalDevice
{
    public string SoftwareVersion { get; set; }
    public string SupportedOperatingSystem { get; set; }

    public SoftwareMedicalDevice(string name, string description, string softwareVersion, string supportedOS)
        : base(name, description)
    {
        SoftwareVersion = softwareVersion;
        SupportedOperatingSystem = supportedOS;
    }

    public void DisplayAdditionalInfo()
    {
        Console.WriteLine($"Версия программы: {SoftwareVersion}");
        Console.WriteLine($"Поддерживаемая ОС: {SupportedOperatingSystem}");
    }
}

class Program
{
    static void Main()
    {
        List<IMedicalObject> medicalObjects = new List<IMedicalObject>();

        medicalObjects.Add(new Patient("Иванов", 35, "Грипп"));
        medicalObjects.Add(new MedicalDevice("ЭКГ-аппарат", "Для измерения сердечной активности"));
        medicalObjects.Add(new PhysicalMedicalDevice("Сканер", "Для рентгеновских снимков", 10.5, "ABC Inc."));
        medicalObjects.Add(new SoftwareMedicalDevice("ECG Viewer", "Для анализа ЭКГ данных", "2.0", "Windows"));

        // Додавання об'єктів класу XRayMachine
        medicalObjects.Add(new XRayMachine("Рентген апарат", "Для рентгенографії", 15.0, "XYZ Corp.", 150));

        // Додавання об'єктів класу MRIScanner
        medicalObjects.Add(new MRIScanner("MRI Сканер", "Для обстеження м'язів", 20.0, "MRI Tech", "Суперпровідність"));

        Console.WriteLine("Информация о медицинских объектах:");
        Console.WriteLine("-------------------");

        foreach (var obj in medicalObjects)
        {
            obj.DisplayInfo();

            // Перевіряємо, чи це фізичний медичний пристрій і виводимо додаткову інформацію, якщо так.
            if (obj is PhysicalMedicalDevice physicalDevice)
            {
                physicalDevice.DisplayAdditionalInfo();
            }
            else if (obj is SoftwareMedicalDevice softwareDevice)
            {
                softwareDevice.DisplayAdditionalInfo();
            }

            Console.WriteLine("-------------------");
        }

        Console.ReadKey();
    }

}
