using System;

namespace Task2
{
    internal struct Worker : IComparable<Worker>
    {
        private string name;
        private string position;

        private DateTime yearOfEmpl;

        public Worker(string name, string position, string yearOfEmpl)
        {
            this.name = name;
            this.position = position;
            this.yearOfEmpl = DateTime.Parse(yearOfEmpl);
        }

        public int CompareTo(Worker other)
        {
            return name.CompareTo(other.name);
        }
        public string GetInfo()
        {
            return $"ФИО: {name} \nДолжность: {position}\nГод принятия на работу: {yearOfEmpl.Year}\n";
        }
        public bool IsWorkedLessThen(int year)
        {
            return year < DateTime.Now.Year - yearOfEmpl.Year;
        }
    }
}
