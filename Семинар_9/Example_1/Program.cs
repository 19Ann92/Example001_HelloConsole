//Нахождение факториала с помощью рекурсии

Console.Clear();


Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());

int FindFactorial(int n)
{
    if (n == 1 || n == 0) return 1;
 
    return n * FindFactorial(n - 1); //(1) - 5 * fact(5-1)  
                                                //(2) - 4 * fact(4-1)
                                                            //(3) - 3 * fact(3-1)
                                                                        //(4) - 2 * fact(2-1)
                                                                                    //1
}
 
Console.WriteLine($"Факториал числа {value} = {FindFactorial(value)}"); //5 = 5 * 4 * 3 * 2 * 1 == 120
