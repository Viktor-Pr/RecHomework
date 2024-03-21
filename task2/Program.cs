// See https://aka.ms/new-console-template for more information

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n. 

static void recurs_natural(int m, int n)
{
    if (m > 0 && m <= n)
    {
        Console.WriteLine(m);
    }
    else if (m > 0 && m >= n)
    {
        Console.WriteLine(m);
    }
    if (m < n)
    {
        recurs_natural(m + 1, n);
    }
    else if (m > n)
    {
        recurs_natural(m - 1, n);
    }
}
recurs_natural(2, 7);