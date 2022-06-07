using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StructFile
{
    class Program
    {
        [SerializableAttribute]
        public struct Circle
        {
            public double X;        // Расположение окружности
            public double Y;        // на осях x и y с радиусом
            public double Radius;

            public Circle(double x, double y, double radius)
            {
                X = x;
                Y = y;
                Radius = radius;
            }

            public string PrintStruct()
            {
                return $"\t--Окружность--\n" +
                    $"Расположение на X:\t {X}\n" +
                    $"Расположение на Y:\t {Y}\n" +
                    $"Радиус окружности:\t {Radius}\n";
            }
        }

        public static string ReadCircleFile(string pathToFile)
        {
            FileStream fileStream = new FileStream(pathToFile, 
                FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            string list = string.Empty;
            Circle circle;

            while (fileStream.Position != fileStream.Length)
            {
                circle = (Circle)binaryFormatter.Deserialize(fileStream);
                list += circle.PrintStruct();
            }
            fileStream.Close();

            return list;
        }

        public static void AppendCircleToFile(string pathToFile, Circle circle)
        {
            FileStream fileStream = new FileStream(pathToFile, 
                FileMode.Append, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, circle);
            fileStream.Flush();
            fileStream.Close();
        }

        public static void Main()
        {
            double x, y, radius;
            string pathToFile;

            Console.WriteLine("Укажите путь к файлу");
            pathToFile = Console.ReadLine();

            Prompt:
            Console.Clear();
            Console.WriteLine($"\t{pathToFile}\n" +
                $"1. Добавить окружность\n" +
                $"2. Вывести список окружностей");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:     // Добавление окружностей
                    Console.Clear();
                    Console.WriteLine("Введите расположение окружности на оси X");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите расположение окружности на оси Y");
                    y = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите радиус окружности");
                    radius = double.Parse(Console.ReadLine());

                    AppendCircleToFile(pathToFile, new Circle(x, y, radius));

                    Console.WriteLine("Окружность добавлена!");
                    Console.ReadKey();
                    goto Prompt;
                case ConsoleKey.D2:     // Вывод всех окружностей на экран
                    Console.Clear();
                    Console.WriteLine(ReadCircleFile(pathToFile));
                    Console.ReadKey();
                    goto Prompt;
                default:
                    Console.WriteLine("Такого пункта меню нет");
                    Thread.Sleep(1000);
                    goto Prompt;
            }
        }
    }
}