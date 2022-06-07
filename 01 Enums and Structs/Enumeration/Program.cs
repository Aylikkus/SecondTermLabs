using System;

namespace Enumeration
{
    // Описание перечисления
    enum WeightType
    {
        LightFly,
        Fly,
        Bantam,
        Light,
        LightWelter,
        Welter,
        Middle,
        LightHeavy,
        Heavy,
        SuperHeavy
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите весовую категорию (англ. или номер)");

            // Вывод перечисления на экран
            Console.WriteLine("Номер\tЗначение");
            foreach (var val in Enum.GetValues(typeof(WeightType)))
            {
                Console.WriteLine($"{(int)val}\t{val}");
            }

            // Объявление переменной перечисляемого типа данных
            // И её инициализация значением с клавиатуры
            Enum.TryParse(Console.ReadLine(), out WeightType userType);

            foreach (var val in Enum.GetValues(typeof(WeightType)))
            {
                if (userType == (WeightType)val)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{(int)userType}\t{userType}");

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine($"{(int)val}\t{val}");
                }
            }

        }
    }
}