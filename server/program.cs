using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторная работа №4 ===");
            Console.WriteLine("Здравствуй, друг!");
            Console.WriteLine("ФИО: Тотьмянин Тихон Алексеевич");
            Console.WriteLine("Группа: ИСП-232");
            Console.WriteLine("Сегодня: " + DateTime.Now);
            
            string choice = "";
            
            while (choice != "4")
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1 - Показать ФИО");
                Console.WriteLine("2 - Показать группу");
                Console.WriteLine("3 - Показать дату");
                Console.WriteLine("4 - Выход");
                Console.Write("Твой выбор: ");
                
                choice = Console.ReadLine();
                
                if (choice == "1")
                {
                    Console.WriteLine("ФИО: Иванов Иван Иванович");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Группа: ИС-201");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Сегодня: " + DateTime.Now);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Пока, друг!");
                }
                else
                {
                    Console.WriteLine("Ошибка! Нужно выбрать 1, 2, 3 или 4");
                }
            }
        }
    }
}