// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetCountNumbers(int count)
{
    int sum = 0;
        while (count >= 1)
    {
        count = count / 10;
        sum++;
    }
    return sum;
}

Console.WriteLine($"Количество цифр в числе {num} = {GetCountNumbers(num)}");
