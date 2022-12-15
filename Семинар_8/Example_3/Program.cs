// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный 
// словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3    1 встречается 3 раза 
// 4, 6, 1    2 встречается 2 раз 
// 2, 1, 6    3 встречается 1 раз 
//            4 встречается 1 раз 
//            6 встречается 2 раза

Console.Clear();


Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

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

int[,] array = FillArray(rows, columns, min, max);
PrintArray(array);

int[] aftersortarray = DoSort(array);
Array.Sort(aftersortarray);

Console.WriteLine($"Вы ввели следующие числа: {string.Join(",", (aftersortarray))}");

PrintData(aftersortarray);

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}

int[] DoSort(int[,] inputArray)
{
    int index = 0;
    int[] newarray = new int[inputArray.GetLength(0) * inputArray.GetLength(1)];



    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            newarray[index] = inputArray[i, j];
            index++;
        }
    }
    return newarray;
}

