// Напишите программу, которая принимает на вход число (А) и выдаёт 
//сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма от 1 до числа {number} = {FindSumToLimit(number)}");

int FindSumToLimit(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum += i;
    }
    return sum;
}
