Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
while (num > 999)
{
num = num / 10;
}
Console.WriteLine(num % 10);
}