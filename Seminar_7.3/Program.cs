// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

//Взято с буткемпа
using static System.Console;

int[] numbers = { 1, 2, 5, 0, 10, 34 };

void ReverseArray(int[] array, int start, int end)
{
    if (start < end)
    {
        // Обмен значениями между начальным и конечным элементами массива 

        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        // Рекурсивный вызов для оставшихся элементов массива
        ReverseArray(array, start + 1, end - 1);
    }
}

ReverseArray(numbers, 0, numbers.Length - 1);

foreach (int i in numbers)
{
    Write($"{i}\t");
}
