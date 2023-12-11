// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

//Взято с семинара, (и я не поняла, что значит Задайте прямоугольный двумерный массив,
//  видимо будет ошибка, так как я сделала через консоль
// чтобы пользователь ввел сам.

void InputMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
        }
    }
}

//Взято с семинара, печатаем массив
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
Console.Write("Введите размеры прямоугольного двумерного массива через пробел:   ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);


//  Инициализируем переменные для наименьшей суммы и ее индекса строки
int minSum = 100; // Начальное значение устанавливаем как максимально возможное
int minSumRowIndex = -1;

//  Проходим по каждой строке матрицы
for (int i = 0; i < matrix.GetLength(0); i++)
{

    //  Вычисляем сумму элементов в текущей строке
    int currentSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        currentSum += matrix[i, j];
    }

    //  Сравниваем текущую сумму с минимальной суммой
    if (currentSum < minSum)
    {
        // Если текущая сумма меньше минимальной, обновляем значения
        minSum = currentSum;
        minSumRowIndex = i;
    }
}

// Выводим результат
Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex}");





