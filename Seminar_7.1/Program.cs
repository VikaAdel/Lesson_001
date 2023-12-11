// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.


//Взято с буткемпа 
using static System.Console;

void printNumbers(int current, int end)
{
    if (current <= end)
    {
        Write($"{current}\t");
        printNumbers(current + 1, end);
    }
}

Clear();
Write("Введите значение M: ");
int m = int.Parse(ReadLine()!);

Write("Введите значение N: ");
int n = int.Parse(ReadLine()!);

printNumbers(m, n);
