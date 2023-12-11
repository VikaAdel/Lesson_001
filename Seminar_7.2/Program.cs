// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

//Взято с буткемпа 
using static System.Console;

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}


Clear();
Write("Введите значение m: ");
int m = int.Parse(ReadLine()!);

Write("Введите значение n: ");
int n = int.Parse(ReadLine()!);

int functionAkkerman = Ack(m, n);
Write($"Функция Аккермана = {functionAkkerman} ");