// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//  в которой находится эта точка.


Console.Write("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка во второй четверти.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти.");
}
else 
{
    Console.WriteLine("Точка находится в четвертой четверти.");
}

