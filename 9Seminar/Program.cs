//task 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Clear();

int Summ(int n, int n1)
{
    if(n1 == n) return n;
    return Summ(n, n1-1) + n1;
}

Console.Write("Введите начальное число >>> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите конечное число >>> ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write(Summ(n, n1));
*/



//task 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermanfunction(int n, int m)
{
    if(n == 0) return m + 1;
    if(n != 0 && m == 0) return Ackermanfunction(n - 1, 1);
    if(n > 0 && m > 0) return Ackermanfunction(n - 1, Ackermanfunction(n, m - 1));
    
    return Ackermanfunction(n,m);
}

Console.Clear();

Console.Write("Напишите 1-ое число >>> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите 2-ое число >>> ");
int m = Convert.ToInt32(Console.ReadLine());


Console.Write(Ackermanfunction(n, m));