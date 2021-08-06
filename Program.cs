using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee calisan = new Employee();
            calisan.name="Ekrem";
            calisan.surname="Sağlam";
            calisan.contactNumber=5365554466;
            calisan.department="IT";
            calisan.printInfo();

        }
    }

    class Employee
    {
        public string name;
        public string surname;
        public long contactNumber;
        public string department;
        public void printInfo()
        {
            Console.WriteLine(name + " " + surname + " isimli çalışanın telefon numarası : " + contactNumber + " deparmanı : " + department);
        }


    }
}
