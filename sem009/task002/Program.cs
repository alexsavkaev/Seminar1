﻿// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m=int.Parse(ReadLine());
Write("Введите N: ");
int n=int.Parse(ReadLine());
WriteLine(PrintNumbers(m,n));
string PrintNumbers(int start, int end)
{
    if (end == start)
    {
        return start.ToString();
    }
    
    string s = PrintNumbers(start, end - 1) + ' ' + end.ToString();
    return (s);
}