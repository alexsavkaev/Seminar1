// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using static System.Console;
Console.Clear();
int Prompt (string message)                                 // Функция для указаний пользователю
{
    Write(message);                                 // выводим заданный текст на экран
    string readInput = ReadLine();                  // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
int DiagonalSumm(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {            
            if(i == j)
            {
                sum += inArray[i,j];
            }
        }
    }
    return sum;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
int line = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int[,] mas = GetArray(line, column);
PrintArray(mas);
WriteLine();
WriteLine($"Сумма главной диагонали равна: {DiagonalSumm(mas)}");