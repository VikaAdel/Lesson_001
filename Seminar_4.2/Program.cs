// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве



Console.Clear();
// Создаем массив  из 10 целых чисел 

int[] numbers = new int[10];
Random random = new Random();

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100, 1000);
    Console.Write(numbers[i] + " ");

    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write($"количество чётных чисел в массиве: {count} ");