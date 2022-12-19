// Задача 66.
// Задайте значения M и N. 
// Вычислить сумму натуральных элементов в промежутке от M до N.

// Пример:

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Начало программы ==========================================================================

Console.WriteLine();
Console.WriteLine("Данная программа считает сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"{"Ответ: "}{Sum(M,N)}");

int Sum (int M, int N)
{
    int sum = 0;
    for (int i = M; i <= N; i++) sum += i;
    return sum;
}