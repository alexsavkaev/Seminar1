// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void PrintArray(int[,] inArray)                                     // Функция для вывода массива
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
void BubbleSortArray(int[,] inArray)                                // Функция для построчной пузырьковой сортировки
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i,j] < inArray[i,k])
                {
                    int t = inArray[i,j];
                    inArray[i,j] = inArray[i,k];
                    inArray[i,k] = t;
                }
            }
        }
    }
}

int[,] table = GetArray(5, 5, 1, 9);
PrintArray(table);
WriteLine();
BubbleSortArray(table);
PrintArray(table);