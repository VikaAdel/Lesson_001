//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Взято с семинара
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 31);
        }
    }
}

//Взято с семинара
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Метод для замены местами двух строк в матрице
void RearrangingStrings(int[,] matrix)
{
    
    int rows = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        //temp вспомогательный элемент 
        int temp = matrix[0, i];
        matrix[0, i] = matrix[rows - 1, i];
        matrix[rows - 1, i] = temp;
    }
}


Console.Clear();
Console.Write("Введите размеры двумерного массива через пробел:   ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
RearrangingStrings(matrix);
Console.WriteLine("\nмассив после замены:");
PrintMatrix(matrix);



