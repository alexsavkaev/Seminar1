// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза*\

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
            result[i, j] = new Random().Next(minValue, maxValue);
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
int[] MinMax(int[,] inArray)
{
    int[] minmax = new int[2];
    int min = inArray[0, 0];
    int max = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            min = inArray[i, j] <= min ? inArray[i, j] : min;
            max = inArray[i, j] >= max ? inArray[i, j] : max;
        }
    }
    minmax[0] = min;
    minmax[1] = max;
    return minmax;
}
int[] AppearanceCount(int[,] inArray)
{
    int[] minmax = MinMax(inArray);               // MinMax[0] - min. Minmax[1] - max
    int[] result = new int[minmax[1]];
    int count = 0;
    for (int k = 0; k < minmax[1]; k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (inArray[i, j] == minmax[0])
                {
                    count += 1;
                }
            }
        }
        result[minmax[0]] = 
        minmax[0] += 1;
    }
    return result;
}
int[,] array = GetArray(5, 5, 1, 10);
PrintArray(array);
int[] minmax = AppearanceCount(array);
Console.WriteLine(String.Join(", ", minmax));