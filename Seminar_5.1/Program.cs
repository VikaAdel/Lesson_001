
// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Пример:
// 4 3 1 (1,2) => 9
// 2 6 9 



//Взято с семинара
//Метод для генерации двумерной матрицы с рандомными числами
void GenerateRandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

        {// Генерируем случайное число от 1 до 49
            matrix[i, j] = new Random().Next(1, 50);
        }
    }

}


// Метод для вывода матрицы на экран
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


Console.Clear();
Console.Write("Введите размеры двумерного массива через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
GenerateRandomMatrix(matrix);

Console.WriteLine("Двумерный массив создан:\n");
PrintMatrix(matrix);

// Запрашиваем номер строки
Console.Write(" Введите номер строки: ");
int row = int.Parse(Console.ReadLine()!);

// Запрашиваем номер столбца
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine()!);

//FindElementIndex(matrix);
//Console.WriteLine("\nмассив после замены:");
//PrintMatrix(matrix);

 // Проверяем введенные пользователем позиции
    if (row >= 0 && row < 50 && col >= 0 && col < 50)
    {
        // Получаем значение элемента по введенным позициям
        int element = matrix[row, col];

        // Выводим результат
        Console.WriteLine($"Элемент в позиции [{row},{col}] равен: {element}");
    }
    else
    {
        // Выводим сообщение об ошибке, если позиции невалидны
        Console.WriteLine("Ошибка: Введены некорректные позиции.");
    }


