// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Clear();

Console.Write("Введите первое число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ost = num2 % num1;

//if (ost == 0) Console.WriteLine($"Число {num2} кратно числу {num1}.");
//else Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток {ost}.");

//Более короткое решение:

Console.WriteLine( ost == 0 ? $"Число {num2} кратно числу {num1}."
: $"Число {num2} не кратно числу {num1}, остаток {ost}.");
