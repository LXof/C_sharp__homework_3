/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Введите координаты двух точек в 3D пространстве");
Console.WriteLine("Координаты точки A:");
Console.Write("\t\tx = ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("\t\ty = ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("\t\tz = ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты точки B:");
Console.Write("\t\tx = ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("\t\ty = ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("\t\tz = ");
int bz = Convert.ToInt32(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine($"Растояние между точками A и B: {Math.Round(ab,5)}.");

Console.WriteLine("Программа завершена.");