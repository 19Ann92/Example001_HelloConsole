// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Изначальный массив: 	Итоговый массив: 
// 1 4 7 2                 8 4 2 4
// 5 9 2 3                 5 9 2 3
// 8 4 2 4                 1 4 7 2

Console.Clear();
Console.Write("Введите число строк массива : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, column, -9, 9);

PrintArray(array);

PrintArray(SwapRow(array));

PrintArray(array);

int[,] SwapRow(int[,] arr)
{
    int exchange = 0;
    int[,] resultArray = (int[,])arr.Clone();
    for (int i = 0; i < resultArray.GetLength(1); i++)
    {
        exchange = resultArray[0, i];
        resultArray[0, i] = resultArray[resultArray.GetLength(0) - 1, i];
        resultArray[resultArray.GetLength(0) - 1, i] = exchange;
    }
    return resultArray;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("----------------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] >= 0 ? $"  {arr[i, j]}" : $" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rowArray, int colArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
        for (int j = 0; j < colArray; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    return resultArray;
}
