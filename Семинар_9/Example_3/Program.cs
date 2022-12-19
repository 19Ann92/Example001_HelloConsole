// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N с помощью рекурсии
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.Clear();

// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int m = Convert.ToInt32(Console.ReadLine());


// if (n>m){
//     FindNumber(m,n);
// }
// else{
    
//     FindNumber(n,m);
// }


// void FindNumber(int ot, int do1)
// {
//     Console.Write(ot + ", ");
//     if (ot == do1) return;

//     FindNumber(ot + 1, do1);
// }

Console.Clear();

Console.WriteLine("Введите любое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число N:");
int n = Convert.ToInt32(Console.ReadLine());


void FindNumber(int ot, int do1) // 5

{
    if (ot == do1 ) Console.Write(ot);
    else Console.Write(ot + " , ");
    if (ot == do1) return; // 0->5


    FindNumber(ot + 1, do1);
}

if( m>n) FindNumber(n, m); 
else FindNumber(m, n);
