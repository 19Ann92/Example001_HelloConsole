// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр с помощью рекурсии.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

//int sum = 0;

int ToMultiplyNumber(int n)
{

    if (n < 1) return 0;
    // int a = n / 10;
    // sum = (n % 10) + ToMultiplyNumber(a);
    // return sum;
    return n % 10 + ToMultiplyNumber(n / 10);

}

Console.WriteLine($"Сумма цифр этого числа = {ToMultiplyNumber(n)}");

