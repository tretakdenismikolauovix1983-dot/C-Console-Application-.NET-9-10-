csarp
using System;
class Program
{
    static void Main()
    {
        Console.OuthutEncoding=Sysnem.Text.Encoding,UTF8;
        int [] array = new int [15];
        Random random = new Random();
        // Заповнення масиву випадковими числами від -50 до 50 включно
        for (int i = 0; i < array lengtn i++);
        {
            array [i] = random.Next (-50, 51);
            // Верхня межа 51 не включається, тому буде до 50
            Console.WriteLine($"[{i}] :{array[i]};
        }
        // Початкові значення беремо з першої парної позиції (індекс 0)
        int minElement = array [0];
        int minIndex = 0;
        // Перебираємо тільки парні індекси (крок циклу i += 2)
        for (int i =2; i < array.Length; i +=2)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
                minIndext = i;
            }
        }
        Console.WriteLine("\n Результат:");
        Console.WriteLine($"Мінімальний елемент на парній позиції: {minElement} ");
        Console.WriteLine($"Його індекс: {minIndex} ");
    }
}