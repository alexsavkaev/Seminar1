﻿// Задача 23

// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine());
if(num < 0)
{
    num = num * -1;
}

for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
