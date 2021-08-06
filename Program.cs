using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee calisan = new Employee("Ekrem", "Sağlam", 5365554466, "IT");
            Employee calisan2 = new Employee("mahmut", "sağlam");
            calisan.printInfo();
            calisan2.printInfo();
            calisan.Name="mehmet";


        }
    }

    class Employee
    {
        private string name;
        private string surname;
        private long contactNumber = 0;
        private string department = null;
        public Employee(string name, string surname, long contactNumber, string department)
        {
            this.name = name;
            this.surname = surname;
            this.contactNumber = contactNumber;
            this.department = department;
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = name;
        }
        public void printInfo()
        {
            Console.WriteLine(name + " " + surname + " isimli çalışanın telefon numarası : " + contactNumber + " deparmanı : " + department);
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Department { get => department; set => department = value; }



    }
}
