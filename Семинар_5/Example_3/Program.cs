// Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное допустимое значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное допустимое значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(",", array)}]");

Console.WriteLine("Введите элемент для поиска в массиве: ");
int search = Convert.ToInt32(Console.ReadLine());

if(IsElement(array, search)) 
    Console.WriteLine("Элемент есть в массиве");
else
    Console.WriteLine("Элемента нет в массиве");

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

bool IsElement(int[] Array, int element)
{
    for(int i=0; i<Array.Length; i++)
    {
        if(Array[i]==element)
            return true;
    }
    return false;    
}
