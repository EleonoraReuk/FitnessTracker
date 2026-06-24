using System;

namespace FitnessTracker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Fitness Tracker ===");
            Console.WriteLine("1. Создать цель");
            Console.WriteLine("2. Добавить тренировку");
            Console.WriteLine("3. Показать прогресс");
            Console.WriteLine("4. Выход");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Цель создана.");
                    break;

                case 2:
                    Console.WriteLine("Тренировка добавлена.");
                    break;

                case 3:
                    Console.WriteLine("Прогресс: 25%");
                    break;

                case 4:
                    Console.WriteLine("Выход из программы.");
                    break;

                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}