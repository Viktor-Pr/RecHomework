
// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы

Console.Clear();
void LineOfDigits(int M, int N)
{
    if (N < M)
    {
        return;
    }
    Console.Write($"{M} ");
    LineOfDigits(M + 1, N);
    
}
Console.WriteLine("Введите первое число промежутка: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число промежутка: ");
int N = Convert.ToInt32(Console.ReadLine());

LineOfDigits(M, N);