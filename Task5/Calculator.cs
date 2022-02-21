using System;

namespace Task5
{
    internal class Calculator
    {
        public double operand1 { get; set; }
        public double operand2 { get; set; }
        private delegate double Action(double operand1, double operand2);
        private Action action;
        private double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        private double Sub(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        private double Mul(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        private double Div(double operand1, double operand2)
        {
            if (operand2 == 0)
                throw new DivideByZeroException();
            return operand1 / operand2;
        }
        public double ParseDouble()
        {
            while (true)
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void SetAction()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    switch (input)
                    {
                        case "+":
                            action = Add;
                            return;
                        case "-":
                            action = Sub;
                            return;
                        case "*":
                            action = Mul;
                            return;
                        case "/":
                            action = Div;
                            return;
                        default:
                            throw new FormatException("Используйте символы +-*/");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void PrintResult()
        {
            try
            {
                Console.WriteLine("Результат: " + action(operand1, operand2));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
