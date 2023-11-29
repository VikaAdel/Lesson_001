// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Clear();
    Console.Write("Введите целое число или 'q' для завершения: ");
    string input = Console.ReadLine();

    // 1 условие, Проверка на символ 'q'
    if (input.ToLower() == "q")
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    // 2 условие,Попытка преобразования введенной строки в число
    if (int.TryParse(input, out int number))
    {
        // Проверка на четность суммы цифр
        if (IsSumOfDigitsEven(number))
        {
            Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
            break;
        }
        else
        {
            Console.WriteLine($"Сумма цифр числа {number} нечетная.");
        }
    }
    else
    {
        Console.WriteLine("Введенное значение не является целым числом. Попробуйте снова.");
    }
}
    

    // Метод для определения четности суммы цифр числа
    static bool IsSumOfDigitsEven(int num)
{
    int sum = 0;

    // Вычисляем сумму цифр числа
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }

    // Проверяем четность суммы
    return sum % 2 == 0;
}