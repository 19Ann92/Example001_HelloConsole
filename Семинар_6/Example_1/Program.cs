// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - 
// на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное допустимое значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное допустимое значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size,min,max);

int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] ReverseArray(int[] arr)
{
    int[] revers = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        revers[i] = arr[arr.Length - 1 - i];
    return revers;
}

Console.WriteLine($"Исходный массив: {string.Join(",",array)}");
Console.WriteLine($"Результатирующий массив: {string.Join(",",ReverseArray(array))}");