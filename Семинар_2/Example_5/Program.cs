// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Clear();

Console.Write("Введите первое число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2) Console.WriteLine($"Число {num1} является квадратом числа {num2}.");
else if (num2 == num1*num1) Console.WriteLine($"Число {num2} является квадратом числа {num1}.");
else Console.WriteLine($"Числа {num1} и {num2} не являются квадратами друг друга.");

//Второй вариант решения
//Console.WriteLine(num1 == num2*num2 || num2 == num1*num1 
//? $"Числа {num1} и {num2} являются взаимными квадратами."
//: $"Числа {num1} и {num2} не являются квадратами друг друга.");
