// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N с помощью рекурсии
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

void FindNumber(int ot, int do1)
{
    Console.Write(ot + " ,");
    if (ot == do1) return;

    FindNumber(ot + 1, do1);
}

FindNumber(1, n);
