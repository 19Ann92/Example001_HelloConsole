// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите любое число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число B:");
int b = Convert.ToInt32(Console.ReadLine());

int ToPowerChisla(int chislo, int step)
{
    if (step == 0) return 1;
    return chislo * ToPowerChisla(chislo, step - 1);
}

// int ToPowerChisla(int A, int B) {
//     if (B == 1) return A;
//     return A * ToPowerChisla(A, B - 1);
// }


Console.WriteLine($"Число {a} в степени {b} = {ToPowerChisla(a, b)}");