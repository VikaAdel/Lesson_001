///Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();
Console.Write(" Введите двузначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10 || n > 99)
{ // 23 < 100 || 23 > 999 -> 1 + 0 = 1
    Console.Write("Вы ошиблись!\nВведите двузначное число: ");
    n = int.Parse(Console.ReadLine()!);
}


int LargeDigit = n % 10 > n / 10 ? n % 10 : n / 10;
Console.WriteLine("наибольшая цифра числа: " + LargeDigit);