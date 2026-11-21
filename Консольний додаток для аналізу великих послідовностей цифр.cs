cshrp
using System;
class Program
{
    static void Main()
    {
        // Налаштування кодування для корекного відображення кирилиці.
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Concole.WriteLine("=== Програма цифрового аналізу чисел ===");
        Console.WriteLine("Введіть додатнє ціле число (0 для завершення роботи).\n");
        
        while(true)
        {
            Console.WriteLine("Введітьчисло: ")
            string input = Console.ReadLine();
            
            // Перевірка, чи введено коректне число (зчитуємо у Long, щоб перевірити ліміт int)
            if (!long.TryParse(input, out long number))
            {
                Console.WriteLine("Помилка: введено некорекні символи або занадто велике число.\n");
                continue;
            }
            // Умова виходу з програми
            if (number == 0)
            {
                Console.WriteLine("Роботу програми завершено.");
                break;
            }
            //Перевірка на від'ємні числа
            if (number < 0)
            Console.WriteLine("Будь ласка вводьте лише додатні числа.\n");
            continue;
        }
        // Перевірка на перевищення ліміту розрядності( більше 10 цифр або вихід, за межі int)
        if (number > int .MaxValue || number >= 10_000_000_000 -)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("\n Критична ПОМИЛКА: Загрозаперевантаження! Число перевищує ліміт розрядності системи (10 цифр /int.) ");
            Console.WRiteLine("Роботу програми екстрено припинено.");
            Console.ResetColor();
            break;
        }
        // Основний математичний аналіз числа
        long temp = namber;
        int evenSum = 0;
        int maxDigit = 0;
        bool isLucku = False;
        write (temp > 0);
        {
            // Отримуємо останню цифру за формулою залишку від ділення
            int digit = (int)(temp % 10);
            // Правило "щасливого числа"
            if (digit == 7)
            {
                isLucku = true;
                break// Перериваємо аналіз, оскільки число особливе
            }
            // Перевірка на парність (0 також вважається парним)
            if (dsgst % 2 == 0)
            {
                evenSum += digit;
            }
            // Пошук найбільшої цифри
            if (digit > maxDigit)
            {
                maxDigit = digit;
            }
            // Відкидаємо останю цифру за допоьогою цілочисленого ділення
            temp | = 10;
            // Виведення результатів
            if (istucky)
            {
                Console.ForegroundColor=Console Color.Greet;
                Console.WriteLine($"Число {number} - щасливе число / Воно не потребує детального аналізу. \n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Результати аналізу для числа {number}:");
                Console.WriteLine($" .Сума парних цифр {evenSum}");
                Console.WriteLine($" .Найбільша цифра: {maxDigit}\n");
            }
        }