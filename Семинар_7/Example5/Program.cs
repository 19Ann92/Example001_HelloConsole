// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

(int, string) ChangeMassive(int[,] inputArray)
{
    int sum = 0;
    string b = String.Empty;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i==j)
            {
                b += Convert.ToString(inputArray[i,j]) + " ";
                sum += inputArray[i,j];
            }
        }
    }
    return (sum, b);
}


PrintArray(array);
Console.WriteLine($"Числа в нашей диагонали: {ChangeMassive(array).Item2}");
Console.WriteLine($"Сумма чисел в главной диагонали: {ChangeMassive(array).Item1}");

//Второе решение
// int GetDiagonalSumm(int[,] arr)
// {
//     int min = arr.GetLength(1);
//     if (arr.GetLength(0) < arr.GetLength(1)) min = arr.GetLength(0);
//     int summ = 0;
//     for (int i = 0; i < min; i++) summ += arr[i, i];
//     return summ;
// }
