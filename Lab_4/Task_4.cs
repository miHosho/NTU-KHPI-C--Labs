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

class Hospital
{
    private List<Patient> patients;

    public Hospital()
    {
        patients = new List<Patient>();
    }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    public void RemovePatient(Patient patient)
    {
        patients.Remove(patient);
    }

    public void DisplayPatients()
    {
        Console.WriteLine("Пациенты в больнице:");
        foreach (Patient patient in patients)
        {
            patient.Show();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();

        Patient patient1 = new Patient("Петров", "Иван", "Олександрович", "ул. Центральная, 123", 1001, "Грипп");
        Patient patient2 = new Patient("Сидорова", "Мария", "Андреевна", "ул. Парковая, 45", 1002, "Ангина");
        Patient patient3 = new Patient("Иванов", "Петро", "Иванович", "ул. Школьная, 67", 1003, "Гастрит");

        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);
        hospital.AddPatient(patient3);

        hospital.DisplayPatients();

        Console.ReadKey();
    }
}

//////////////////////////////////////////////////////////////////////////////////////////
///
*//*class Patient
{
    private string lastName;
    private string firstName;
    private string middleName;
    private string address;
    private int medicalCardNumber;
    private string diagnosis;

    public Patient(string lastName, string firstName, string middleName, string address, int medicalCardNumber, string diagnosis)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.address = address;
        this.medicalCardNumber = medicalCardNumber;
        this.diagnosis = diagnosis;
    }

    public void Show()
    {
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Имя: {firstName}");
        Console.WriteLine($"Отчество: {middleName}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Номер медицинской карты: {medicalCardNumber}");
        Console.WriteLine($"Диагноз: {diagnosis}");
    }
}

class Hospital
{
    private List<Patient> patients;

    public Hospital()
    {
        patients = new List<Patient>();
    }

    public void AddPatient(string lastName, string firstName, string middleName, string address, int medicalCardNumber, string diagnosis)
    {
        patients.Add(new Patient(lastName, firstName, middleName, address, medicalCardNumber, diagnosis));
        //patients.Add(patient);
    }

    public void DisplayPatients()
    {
        Console.WriteLine("Пациенты в больнице:");
        foreach (Patient patient in patients)
        {
            patient.Show();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();

        hospital.AddPatient("Петров", "Иван", "Олександрович", "ул. Центральная, 123", 1001, "Грипп");
        hospital.AddPatient("Сидорова", "Мария", "Андреевна", "ул. Парковая, 45", 1002, "Ангина");
        hospital.AddPatient("Иванов", "Петро", "Иванович", "ул. Школьная, 67", 1003, "Гастрит");

        hospital.DisplayPatients();

        Console.ReadKey();
    }
}*/