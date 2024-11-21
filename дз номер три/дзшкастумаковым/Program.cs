using System;

class Program
{
    static void Main()
    {
        // Упражнение 4.1
        Console.WriteLine("Задача 4.1: Программа переводит номер дня в году (от 1 до 365) в месяц и день.");
        Console.Write("Введите номер дня в году (от 1 до 365): ");

        int dayOfYear = int.Parse(Console.ReadLine());

        // Упражнение 4.2
        if (dayOfYear < 1 || dayOfYear > 365)
        {
            throw new ArgumentOutOfRangeException("Число должно быть от 1 до 365.");
        }

        // Массивы для хранения количества дней в каждом месяце
        string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30,
                               31, 31, 30, 31, 30, 31 };

        int month = 0;
        int day = dayOfYear;

        for (int i = 0; i < daysInMonth.Length; i++)
        {
            if (day > daysInMonth[i])
            {
                day -= daysInMonth[i];
            }
            else
            {
                month = i + 1;
                break;
            }
        }

        Console.WriteLine($"День {dayOfYear} соответствует {day} {months[month - 1]}.");

        // Домашнее задание 4.1
        Console.WriteLine("\nДомашнее задание 4.1: Учитываем високосный год.");
        Console.Write("Введите год: ");

        int year = int.Parse(Console.ReadLine());

        // Проверка на високосный год
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        // Изменяем количество дней в феврале, если год високосный
        if (isLeapYear)
        {
            daysInMonth[1] = 29; // Февраль в високосный год
        }

        // Пересчитываем месяц и день с учетом нового количества дней
        month = 0;
        day = dayOfYear;

        for (int i = 0; i < daysInMonth.Length; i++)
        {
            if (day > daysInMonth[i])
            {
                day -= daysInMonth[i];
            }
            else
            {
                month = i + 1;
                break;
            }
        }

        Console.WriteLine($"В {year} году день {dayOfYear} соответствует {day} {months[month - 1]}.");
    }
}
