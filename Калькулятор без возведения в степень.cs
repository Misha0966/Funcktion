using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 

            
            switch (op)
            {
                case "C":
                    result = num1 + num2;
                    break;
                case "В":
                    result = num1 - num2;
                    break;
                case "У":
                    result = num1 * num2;
                    break;
                case "Д":
                    
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("Консольный калькулятор в C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
            
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Введите число нажав клавишу Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Это недопустимый ввод. Пожалуйста, введите целое значение: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Введите следующее число, нажав клавишу Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Это недопустимый ввод. Пожалуйста, введите целое значение: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Вам доступны следующие опреции, выберите одну из них соответсвующей буквой:");
                Console.WriteLine("\tС - Сложение");
                Console.WriteLine("\tВ - Вычитание");
                Console.WriteLine("\tУ - Умножение");
                Console.WriteLine("\tД - Деление");
                Console.Write("Ваше действие? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Эта операция приведет к математической ошибке.\n");
                    }
                    else Console.WriteLine("Ваш результат: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(" При попытке выполнить математические вычисления возникло исключение.\n - Детали: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.Write("Зажмите комбинацию клавиш Ctrl + C для выхода из программы, или нажмите клавишу Enter для продолжения: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}