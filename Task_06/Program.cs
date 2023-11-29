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

void test(ref int m)
{
    m = m + 10;
}
Console.Clear();
int n = 7;
test(ref n);
Console.Write(n);

