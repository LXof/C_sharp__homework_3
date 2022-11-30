/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.Clear();
Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число.");
int num = Convert.ToInt32(Console.ReadLine());
int count = num.ToString().Length;;

int fierst = num / 10000;
int second = (num / 1000) % 10;
int fourth = (num / 10) % 10;
int fifth = num % 10;


if (count == 5)
{
    if (fierst == fifth && second == fourth)
        Console.WriteLine($"Число {num} ЯВЛЯЕТСЯ палиндромом.");
    else 
        Console.WriteLine($"Число {num} НЕ является палиндромом.");
}
else
    Console.WriteLine("Число не пятизначное!");


Console.WriteLine("Программа завершена.");