// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.Write("Введите число: ");
//         int n = int.Parse(Console.ReadLine()!);


//         for (int i = -n; i <= n; i++) // i = (-1) * n  i++ <-> i = i + 1 
//             Console.Write($"{i} "); // i + " "


//         // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//         Console.Clear();
//         Console.WriteLine("Введите число: ");
//         int number = Convert.ToInt32(Console.ReadLine()!);

//         if (number % 7 == 0 && number % 23 == 0)

//         {
//             Console.WriteLine($"{number} кратно 7 и 23.");
//         }
//         else
//         {
//             Console.WriteLine($"{number} не кратно 7 и 23.");
//         }


//         // Напишите программу, которая принимает на вход координаты точки (X и Y),
//         //  причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//         //  в которой находится эта точка.


//         Console.Write("Введите значение X: ");
//         int x = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите значение Y: ");
//         int y = Convert.ToInt32(Console.ReadLine());

//         if (x > 0 && y > 0)
//         {
//             Console.WriteLine("Точка находится в первой четверти.");
//         }
//         else if (x < 0 && y > 0)
//         {
//             Console.WriteLine("Точка во второй четверти.");
//         }
//         else if (x < 0 && y < 0)
//         {
//             Console.WriteLine("Точка находится в третьей четверти.");
//         }
//         else
//         {
//             Console.WriteLine("Точка находится в четвертой четверти.");
//         }



//         ///Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

//         Console.Clear();
//         Console.Write(" Введите двузначное число: ");
//         int n = int.Parse(Console.ReadLine()!);
//         while (n < 10 || n > 99)
//         { // 23 < 100 || 23 > 999 -> 1 + 0 = 1
//             Console.Write("Вы ошиблись!\nВведите двузначное число: ");
//             n = int.Parse(Console.ReadLine()!);
//         }


//         int LargeDigit = n % 10 > n / 10 ? n % 10 : n / 10;
//         Console.WriteLine("наибольшая цифра числа: " + LargeDigit);


//         //Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
//         int CountOfDigits(int number)

//         Console.Write("Введите натуральное число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         if (N < 10)
//         {
//             Console.WriteLine(N);
//         }
//         else
//         {
//             while (N > 0)
//             {
//                 int currentDigit = N % 10;
//                 N /= 10;
//                 if (N > 0)
//                 {
//                     Console.Write(currentDigit + ",");
//                 }
//                 else
//                 {
//                     Console.WriteLine(currentDigit);
//                 }
//             }
//         }
//     }
// }







// Семинар 6. Массивы и строки

// // Задание 1. Задание 1. Совместная работа. Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Конструктор строки вида string(char []) не использовать.

// Console.Clear();
// // char[] chars = {'a', 'b', 'c', 'd'};
// Console.Write("Введите символы через пробел: ");
// char[] chars = Console.ReadLine()!.Split().Select(x => char.Parse(x)).ToArray();
// /*
// 1. "a b 1 2 3 4 6 c d e"
// 2. ["a", "b", "1", "2", "3", "4", "6", "c", "d", "e"]
// 3. 'a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e'
// 4. ['a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e']
// */
// string result = string.Empty; // создание пустой строки
// // string result = "";
// foreach (char element in chars){
//     result = result + element;
// }
// Console.WriteLine(result);







// Задача 2:
// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// Пример:
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’] 

// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = new char[initial.Length];
// // Hello
// // 01234
// for (int i = 0; i < initial.Length; i++)
// {
//     chars[i] = initial[i];
// }
// Console.WriteLine($"Результат: [{string.Join(" ", chars)}]");








// Задание 3. 
// Семинар 6. Массивы и строки
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
// Пример:
// “hello” => 2
// “world” => 1


// bool is_vowels(char el, char[] chars)
// {
//     foreach (char x in chars)
//     {
//         if (x == el)
//             return true;
//     }
//     return false;
// }


// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = { 'a', 'e', 'u', 'i', 'o', 'y' };
// int count = 0;
// for (int i = 0; i < initial.Length; i++)
// {
//     if (is_vowels(initial[i], chars))
//         count++;
// }
// Console.WriteLine(count);



  
    