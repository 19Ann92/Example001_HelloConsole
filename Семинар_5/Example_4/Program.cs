// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в 
//отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении 
//сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 999);
    }
    return arr;
}

int[] arr = FillingArray(123);

Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.WriteLine("]");

int FindNumberOfElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}

int result = FindNumberOfElements(arr);

Console.WriteLine($"Количество эллементов массива от 10 до 99: {result}");