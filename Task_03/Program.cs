//Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.


// Создаем массив из вещественных чисел с нулевой дробной частью
double[] numbers = { 2.2, 0.4, 9.11, 7.2, 78.98 };

// Находим минимальное и максимальное значение в массиве
double min = double.MaxValue;
double max = double.MinValue;

foreach (double number in numbers)
{
    if (number < min)
    {
        min = number;
    }

    if (number > max)
    {
        max = number;
    }
}

// Находим разницу между максимальным и минимальным элементом
double difference = max - min;

// Выводим результат

Console.WriteLine($"Разница между максимальным и минимальным элементом: {difference}");
