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






// //Сортировка массива(Сортировка выбором)

// int[] InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-20, 21);
//     return array;
// }




// int[] sortVibor(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int indexMin = i;
//         for (int j = i; j < array.Length; j++)
//         {
//             if (array[j] < array[indexMin])
//                 indexMin = j;
//         }
//         if (array[indexMin] == array[i])
//             continue;

//         int temp = array[i];
//         array[i] = array[indexMin];
//         array[indexMin] = temp;
//     }
//     return array;
// }

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(" ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(" ", sortVibor(array))}]");





// // Рекурсия
// // Напишите программу, которая принимает от пользователя 2 числа. 
// // Необходимо сложить введенные числа, без прямого сложения.

// int summa(int a, int b){
//     if (b == 0)
//         return a;
//     return summa(a + 1, b - 1);
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {a} + {b} = {summa(a, b)}");

// /*
// a = 5 b = 3 S = summa

// S(5, 3) -> S(6, 2) -> S(7, 1) -> S(8, 0) -> 8
// */








// /*
// Задача 1.
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// */


// int summaCifr(int n){
//     if (n < 10)
//         return n;
//     return summaCifr(n / 10) + n % 10;
// }

// /* n = 456 S = summaCifr
// S(456) -> S(45) + 6 = 4 + 5 + 6 = 15
//             |
//             S(4) + 5 = 4 + 5
//               |
//               4

// */


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // int result = 0;
// // while (n >= 10){ // n < 10 || n % 10 = n || n / 10 == 0
// //     result += n % 10;
// //     n /= 10;
// // }
// // Console.WriteLine(result + n);
// Console.WriteLine(summaCifr(n));







// Задача 2.
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// */
// string printNumbers(int n){
//     if (n == 0) // n == 1
//         return ""; // return "1 "
//     return printNumbers(n - 1) + $"{n} ";
// }
// /*
// n = 5 P = printNumbers
// P(5) -> P(4) + "5 " = "1 2 3 4 " + "5 " =  "1 2 3 4 5 "
//         |
//         P(3) + "4 " = "1 2 3 " + "4 " = "1 2 3 4 "
//         |
//         P(2) + "3 " = "1 2 " + "3 " = "1 2 3 "
//         |
//         P(1) + "2 " = "1 " + "2 " = "1 2 "
//         |
//         P(0) + "1 " = "" + "1 " = "1 "
//         |
//         ""
// */


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(n));




// /*
// Задача 3
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// */

// bool checkVowels(char s)
// {
//     char[] c = { 'e', 'u', 'i', 'y', 'a', 'o' };
//     foreach (char el in c)
//     {
//         if (el == s)
//             return false;
//     }
//     return true;
// }


// string printChars(string s)
// {
//     if (s.Length == 0)
//         return "";

//     string s_new = String.Empty;
//     for (int i = 0; i < s.Length - 1; i++)
//         s_new += s[i];

//     if (checkVowels(s[s.Length - 1]))
//     {
//         return printChars(s_new) + $"{s[s.Length - 1]} ";
//     }
//     return printChars(s_new);
// }
// /*
// s = "hello" P = printChars
// P("hello") -> P("hell")
//                 |
//                 P("hel") + "l "
//                 |
//                 P("he") + "l "
//                 |
//                 P("h")
//                 |
//                 P("") + "h "
//                 |
//                 ""
// */

// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// Console.WriteLine(printChars(initial));


