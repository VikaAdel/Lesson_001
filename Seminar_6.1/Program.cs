// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


Console.Clear();
char[,] charArray =
{
    {'H', 'e', 'l', 'l', 'o'},
    {'W', 'o', 'r', 'l', 'd'}
};
//char[] chars = Console.ReadLine()!.Split().Select(x => char.Parse(x)).ToArray();

string result = string.Empty; // создание пустой строки

foreach (char element in charArray)
{
    result = result + element;
}
Console.WriteLine(result);
//string initial = Console.ReadLine()!;
