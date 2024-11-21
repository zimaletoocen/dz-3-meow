using System;

class meow
{
    static void Main()
    {
        // Задача 1: Проверка упорядоченности последовательности
        Console.WriteLine("Задача 1: Проверка упорядоченности последовательности из 10 чисел.");
        int[] numbers = new int[10];
        Console.WriteLine("Введите 10 чисел:");

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int firstViolationIndex = -1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                firstViolationIndex = i;
                break;
            }
        }

        if (firstViolationIndex == -1)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine($"Последовательность нарушена на элементе с индексом {firstViolationIndex} (значение: {numbers[firstViolationIndex]}).");
        }

        // Задача 2: Определение достоинства карты по номеру
        Console.WriteLine("\nЗадача 2: Определение достоинства карты по её номеру (6-14).");
        try
        {
            Console.Write("Введите номер карты (6-14): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 6 || k > 14)
                throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");

            string cardValue;
            switch (k)
            {
                case 11:
                    cardValue = "Валет";
                    break;
                case 12:
                    cardValue = "Дама";
                    break;
                case 13:
                    cardValue = "Король";
                    break;
                case 14:
                    cardValue = "Туз";
                    break;
                default:
                    cardValue = k.ToString(); // Остальные карты соответствуют их номерам
                    break;
            }
            Console.WriteLine($"Достоинство карты: {cardValue}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное число.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Завершение проверки карты.");
        }

        // Задача 3: Определение напитка по профессии
        Console.WriteLine("\nЗадача 3: Определение напитка по профессии.");
        Console.Write("Введите профессию: ");
        string profession = Console.ReadLine().ToLower();

        switch (profession)
        {
            case "jabroni":
                Console.WriteLine("Напиток: Patron Tequila");
                break;
            case "school counselor":
                Console.WriteLine("Напиток: Anything with Alcohol");
                break;
            case "programmer":
                Console.WriteLine("Напиток: Hipster Craft Beer");
                break;
            case "bike gang member":
                Console.WriteLine("Напиток: Moonshine");
                break;
            case "politician":
                Console.WriteLine("Напиток: Your tax dollars");
                break;
            case "rapper":
                Console.WriteLine("Напиток: Cristal");
                break;
            default:
                Console.WriteLine("Напиток: Beer");
                break;
        }

        // Задача 4: Название дня недели по порядковому номеру
        Console.WriteLine("\nЗадача 4: Название дня недели по порядковому номеру.");
        Console.Write("Введите номер дня недели (1-7): ");

        int dayNumber = int.Parse(Console.ReadLine());

        DaysOfWeek day = (DaysOfWeek)(dayNumber - 1);
        Console.WriteLine($"День недели: {day}");
        // Задача 5: Подсчет кукол в "сумке"
        Console.WriteLine("\nЗадача 5: Подсчет кукол в 'сумке'.");

        string[] dolls = { "Hello Kitty", "Barbie doll", "Action Figure", "Teddy Bear" };
        int bagCount = 0;

        foreach (var doll in dolls)
        {
            if (doll == "Hello Kitty" || doll == "Barbie doll")
            {
                bagCount++;
            }
        }

        Console.WriteLine($"Количество кукол в 'сумке': {bagCount}");
    }

    enum DaysOfWeek
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
}
