using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            for (int i = 0; i < workers.Length;)
            {
                Console.WriteLine("Введите данные о работнике в формате [ФИО ; Должность ; Год принятия на работу]");
                string[] inputString = Console.ReadLine().Split(';');
                try
                {
                    workers[i] = new Worker(inputString[0], inputString[1], inputString[2]);
                    i++;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Используйте следующий формат. Ошибка: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Array.Sort(workers);
            Console.WriteLine("Укажите необходимы стаж работника.");
            int filter;
            while (true)
            {
                try
                {
                    filter = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine($"Данные работники работали больше чем {filter} (лет)");
            foreach (var item in workers)
            {
                if (item.IsWorkedLessThen(filter))
                {
                    Console.Write(item.GetInfo());
                }
            }
        }
    }
}
