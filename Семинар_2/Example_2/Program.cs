// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

Console.Clear();

int num = new Random().Next(100, 1000);

Console.WriteLine($"Сгенерировано случайное чило - {num}");

int num1 = num / 100;
int num2 = num % 10;

int res = num1 * 10 + num2;

Console.WriteLine($"Получилось двузначное число - {res}");
