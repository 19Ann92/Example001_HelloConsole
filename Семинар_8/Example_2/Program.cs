// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на 
// столбцы. В случае, если это невозможно, программа должна вывести сообщение для 
// пользователя.
// Исходный массив:		Результат замены:
// 9 2 3          			9 4 2			
// 4 2 4          			2 2 6
// 2 6 7 				    3 4 7

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

PrintArray(array);
Console.WriteLine();

if(array.GetLength(0) != array.GetLength(1))
{
    Console.WriteLine("Невозможно перевернуть массив");
}
else
{
PrintArray(FlipArray(array));
}

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

int[,] FlipArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[i, j] = array[j, i];
        }
    }
    return resultArray;
}

//Как перевернуть массив с разным количеством строк и столбцов

// if (numOfCols == numOfRows) 
// {
//     for (int r = 0; r < myArray.GetLength(0); r ++){
//         for (int c = r; c <myArray.GetLength(1); c ++) {
//             (myArray[r, c], myArray[c, r]) = (myArray[c, r], myArray[r, c]);
//     }
//     }
//     PrintArray(myArray);
// }
// else {
//     for (int r = 0; r < myArray.GetLength(0); r ++){
//         for (int c = 0; c <myArray.GetLength(1); c ++) {
//             newArray[c, r] = myArray[r, c];
//     }
//     }
//     PrintArray(newArray);
// }
