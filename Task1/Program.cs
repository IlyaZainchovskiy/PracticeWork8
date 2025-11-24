
namespace Task1
{
    public delegate double FunctionDelegate(double x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення x: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out double x))
            {
                Console.WriteLine("Потрібно було ввести число");
                return;
            }
            FunctionDelegate operation;
            if (x < 0)
            {
                operation = MethodNegative;
            }
            else if (x > 0)
            {
                operation = MethodPositive;
            }
            else
            {
                operation = MethodZero;
            }
            double result = operation(x);

            Console.WriteLine($"Результат F({x}) = {result}");

            Console.ReadKey();
        }

        static double MethodNegative(double x)
        {
            return 4 * x - 1;
        }
        static double MethodPositive(double x)
        {
            return 25 * x + 10;
        }
        static double MethodZero(double x)
        {
            return 0;
        }
    }
}