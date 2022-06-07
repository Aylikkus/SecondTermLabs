using System;

namespace Structures
{
    public struct VacuumCleaner
    {
        string Brand;
        string Model;
        double Price;
        bool Bagged;
        bool HasBattery;

        public VacuumCleaner(string brand, string model, 
            double price, bool bagged, bool hasBattery)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Bagged = bagged;
            HasBattery = hasBattery;
        }

        public string PrintStruct()
        {
            return ($"-- Пылесос --\n" +
                    $"Бренд\t - {Brand}\n" +
                    $"Модель\t - {Model}\n" +
                    $"Цена\t - {Price} руб.\n" +
                    $"Мешок\t - {Bagged}\n" +
                    $"Батарея\t - {HasBattery}");
        }

    }

    class Program
    {
        static void Main()
        {
            VacuumCleaner userVacCl;
            string brand, model, prompt;
            bool bagged, hasBattery;
            int price;

            Console.WriteLine("Введите бренд пылесоса");
            brand = Console.ReadLine();

            Console.WriteLine("\nВведите модель пылесоса");
            model = Console.ReadLine();

            Console.WriteLine("\nВведите цену пылесоса");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine("\nУ пылесоса имеется мешок? [Д/н]");
            prompt = Console.ReadLine();
            if (prompt == "н" || prompt == "Н")
                bagged = false;
            else
                bagged = true;

            Console.WriteLine("\nУ пылесоса имеется батарея? [д/Н]");
            prompt = Console.ReadLine();
            if (prompt == "д" || prompt == "Д")
                hasBattery = true;
            else
                hasBattery = false;

            userVacCl = new(brand, model, price, bagged, hasBattery);
            Console.WriteLine(userVacCl.PrintStruct());
        }
    }
}