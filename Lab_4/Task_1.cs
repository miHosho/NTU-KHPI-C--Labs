/*using System;
using System.Collections.Generic;

class Patient
{
    private string lastName;
    private string firstName;
    private string middleName;
    private string address;
    private int medicalCardNumber;
    private string diagnosis;

    // Конструктор класса для инициализации объекта пациента.
    public Patient(string lastName, string firstName, string middleName, string address, int medicalCardNumber, string diagnosis)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.address = address;
        this.medicalCardNumber = medicalCardNumber;
        this.diagnosis = diagnosis;
    }

    // Свойства (getters и setters) для доступа к полям класса.
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string MiddleName
    {
        get { return middleName; }
        set { middleName = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public int MedicalCardNumber
    {
        get { return medicalCardNumber; }
        set { medicalCardNumber = value; }
    }

    public string Diagnosis
    {
        get { return diagnosis; }
        set { diagnosis = value; }
    }

    // Метод для вывода информации о пациенте.
    public void Show()
    {
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Имя: {firstName}");
        Console.WriteLine($"Отчество: {middleName}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Номер медицинской карты: {medicalCardNumber}");
        Console.WriteLine($"Диагноз: {diagnosis}");
    }

    // Метод для поиска пациентов по диагнозу.
    public static List<Patient> FindByDiagnosis(List<Patient> patients, string targetDiagnosis)
    {
        List<Patient> matchingPatients = new List<Patient>();
        foreach (Patient patient in patients)
        {
            if (patient.Diagnosis.Equals(targetDiagnosis, StringComparison.OrdinalIgnoreCase))
            {
                matchingPatients.Add(patient);
            }
        }
        return matchingPatients;
    }

    // Метод для поиска пациентов по номеру медицинской карты в заданном интервале.
    public static List<Patient> FindByMedicalCardNumberRange(List<Patient> patients, int minCardNumber, int maxCardNumber)
    {
        List<Patient> matchingPatients = new List<Patient>();
        foreach (Patient patient in patients)
        {
            if (patient.MedicalCardNumber >= minCardNumber && patient.MedicalCardNumber <= maxCardNumber)
            {
                matchingPatients.Add(patient);
            }
        }
        return matchingPatients;
    }
}

class Program
{
    static void Main()
    {
        // Создание списка пациентов.
        List<Patient> patients = new List<Patient>();

        // Добавление пациентов в список (используйте случайные данные).
        patients.Add(new Patient("Петров", "Иван", "Олександрович", "ул. Центральная, 123", 1001, "Грипп"));
        patients.Add(new Patient("Сидорова", "Мария", "Андреевна", "ул. Парковая, 45", 1002, "Ангина"));
        patients.Add(new Patient("Иванов", "Петро", "Иванович", "ул. Школьная, 67", 1003, "Гастрит"));

        // Вывод всех пациентов.
        Console.WriteLine("Список всех пациентов:");
        foreach (Patient patient in patients)
        {
            patient.Show();
            Console.WriteLine("");
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        // Поиск пациентов по диагнозу.
        string targetDiagnosis = "Грипп";
        List<Patient> matchingPatientsDiagnosis = Patient.FindByDiagnosis(patients, targetDiagnosis);

        Console.WriteLine($"Пациенты с диагнозом '{targetDiagnosis}':");
        foreach (Patient patient in matchingPatientsDiagnosis)
        {
            patient.Show();
            Console.WriteLine();
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        // Поиск пациентов по номеру медицинской карты в заданном интервале.
        int minCardNumber = 1002;
        int maxCardNumber = 1003;
        List<Patient> matchingPatientsCardNumber = Patient.FindByMedicalCardNumberRange(patients, minCardNumber, maxCardNumber);

        Console.WriteLine($"Пациенты с номерами медицинских карт от {minCardNumber} до {maxCardNumber}:");
        foreach (Patient patient in matchingPatientsCardNumber)
        {
            patient.Show();
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
*/