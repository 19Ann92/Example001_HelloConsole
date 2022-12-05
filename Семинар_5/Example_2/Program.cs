// Задача 32: Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение массива");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(",", array)}]");

int[] modifiedArray = ReplaceNumbers(array);
Console.WriteLine($"Получившийся массив: [{string.Join(",", modifiedArray)}]");


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

int[] ReplaceNumbers(int[] Array)
{
     int[] resultArray= new int[Array.Length];
    for(int i=0; i<Array.Length; i++)
        resultArray[i]=(-1)*Array[i];
    return resultArray;      
}