// **Задача 53:** Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using System;
using static System.Console;
Console.Clear();
int[,] GetArray(int lines, int columns, int minValue, int maxValue) // Функция для создания массива по вводимым требованиям
{
    int[,] result = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)                              // Функция для вывода массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");                   // Вывод числа с одним знаком после запятой
        }
        WriteLine();
    }
}
void RevolveArray(int[,] inArray, int a, int b)
{
    
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[a -1, i];
        inArray[a -1, i] = inArray[b-1, i];
        inArray[b-1, i] = k;
    }
}
int[,] array = GetArray(3, 5, 1, 10);
PrintArray(array);
RevolveArray(array, 1, array.GetLength(0));
WriteLine();
PrintArray(array);

