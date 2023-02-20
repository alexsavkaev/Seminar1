// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
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
int[,] RevolveArray(int[,] inArray)
{
    int[,] tempArray = new int[inArray.GetLength(1), inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            tempArray[i, j] = inArray[j, i];
        }
    }
    return tempArray;
}
int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);
int[,] revolvedArray = RevolveArray(array);
WriteLine();
PrintArray(revolvedArray);


