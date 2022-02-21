using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Введите первое число.");
            calculator.operand1 = calculator.ParseDouble();

            Console.WriteLine("Введите один из вариантов действия (/*-+)");
            calculator.SetAction();

            Console.WriteLine("Введите второе число.");
            calculator.operand2 = calculator.ParseDouble();

            calculator.PrintResult();
        }
    }
}
