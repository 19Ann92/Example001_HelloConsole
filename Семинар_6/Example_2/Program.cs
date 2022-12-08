// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
// суммы двух других сторон.

//Пример без метода

// Console.Clear();
// Console.Write("Введите первое число: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdNum = Convert.ToInt32(Console.ReadLine());

// if (firstNum < secondNum + thirdNum)
// {
//     if (secondNum < firstNum + thirdNum)
//     {
//         if (thirdNum < firstNum + secondNum)
//         {
//             Console.WriteLine($"Треугольник может существовать со сторонами такой длины");
//         }

//     }
// else
//         {
//             Console.WriteLine($"Треугольник не может существовать со сторонами такой длины");
//         }
// }

//Пример с методом

Console.Clear();

Console.WriteLine("Введите размер первой стороны треугольника");
int oneNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер второй стороны треугольника");
int twoNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер третьей стороны треугольника");
int treeNum = Convert.ToInt32(Console.ReadLine());

bool getTriangle (int one, int two, int tree)
{
    if  (one + two > tree && two + tree > one && one + tree > two)
    {
        return true;
    }
    else return false;

}

Console.WriteLine(getTriangle(oneNum, twoNum, treeNum) ? "Такой треугольник может существовать" : "Такой треугольник не может существовать");
