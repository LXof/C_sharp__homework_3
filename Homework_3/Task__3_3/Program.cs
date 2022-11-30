/* Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
2,3 -> 8, 27
1,5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.WriteLine("Введите 2 числа M и N, где N < M");
Console.Write("M = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int m = Convert.ToInt32(Console.ReadLine());
double res = 0;
if (n < m)
{
    while (n < m)
    {
        res = Math.Pow(n, 3);
        Console.Write($"{res}, ");
        n++;
    }
        res = Math.Pow(n, 3);
        Console.Write($"{res}.");
} 
else Console.WriteLine("По условию должно быть: n < m");

Console.WriteLine("Программа завершена.");

