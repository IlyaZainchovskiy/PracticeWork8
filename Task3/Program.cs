using System;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введіть перше число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть операцію (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Введіть друге число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Func<double, double, double> operation = null;

                switch (op)
                {
                    case "+":
                        operation = Add;
                        break;
                    case "-":
                        operation = Subtract;
                        break;
                    case "*":
                        operation = Multiply;
                        break;
                    case "/":
                        operation = Divide;
                        break;
                    default:
                        Console.WriteLine("Невідома операція!");
                        return;
                }

                if (operation != null)
                {
                    double result = operation(num1, num2);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Помилка: Ділення на нуль (або невизначений результат).");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: Введено некоректне число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }

            Console.ReadKey();
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                return double.NaN;
            }
            return x / y;
        }
    }
}