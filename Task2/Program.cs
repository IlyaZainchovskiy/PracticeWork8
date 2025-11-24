using System;
using System.Text;

namespace Task2
{
    public delegate void DayDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть номер дня тижня (1-7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                DayDelegate selectedDay = null;

                switch (dayNumber)
                {
                    case 1: selectedDay = Monday; break;
                    case 2: selectedDay = Tuesday; break;
                    case 3: selectedDay = Wednesday; break;
                    case 4: selectedDay = Thursday; break;
                    case 5: selectedDay = Friday; break;
                    case 6: selectedDay = Saturday; break;
                    case 7: selectedDay = Sunday; break;
                }
                selectedDay?.Invoke();
            }
            else
            {
                Console.WriteLine("Помилка: Введіть ціле число від 1 до 7.");
            }

            Console.ReadKey();
        }


        static void Monday()
        {
            Console.WriteLine("--- Понеділок ---");
            Console.WriteLine("1. Нарада о 9:00");
            Console.WriteLine("2. Перевірка пошти");
        }

        static void Tuesday()
        {
            Console.WriteLine("--- Вівторок ---");
            Console.WriteLine("1. Робота над звітом");
            Console.WriteLine("2. Спортзал");
        }

        static void Wednesday()
        {
            Console.WriteLine("--- Середа ---");
            Console.WriteLine("1. Зустріч з клієнтом");
            Console.WriteLine("2. Курси англійської");
        }

        static void Thursday()
        {
            Console.WriteLine("--- Четвер ---");
            Console.WriteLine("1. Код-рев'ю");
            Console.WriteLine("2. Замовлення води в офіс");
        }

        static void Friday()
        {
            Console.WriteLine("--- П'ятниця ---");
            Console.WriteLine("1. Здача проекту");
            Console.WriteLine("2. Піца з колегами");
        }

        static void Saturday()
        {
            Console.WriteLine("--- Субота ---");
            Console.WriteLine("1. Прибирання");
            Console.WriteLine("2. Перегляд фільму");
        }

        static void Sunday()
        {
            Console.WriteLine("--- Неділя ---");
            Console.WriteLine("1. Сімейний обід");
            Console.WriteLine("2. Підготовка до понеділка");
        }
    }
}