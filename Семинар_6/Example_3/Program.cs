// Задача 45: Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
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

int[] getCopyMassive (int[] massive)
{
    int[] copyMassive = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        copyMassive[i] = massive[i];
    }
    return copyMassive;
}

Console.WriteLine($"Исходный массив: {string.Join(",",array)}");
Console.WriteLine($"Скопированный массив: {string.Join(",",getCopyMassive(array))}");
