// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
void LowerSumm(int[,] inArray)                                      // Функция для подсчёта сумм строк
{
    int min = 0;                                                    // Накопитель минимальных сумм
    int line = 0;                                                   // Счётчик строк
    for (int i = 0; i < inArray.GetLength(1); i++)                  // Сумма первой строки записывается в min 
    {
        min += inArray[0, i];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)                  // Цикл для нахождения сумм строк
    {
        int sum = 0;                                                // Сумма для сравнения с min
        int count = 0;                                              // Счётчик строк
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
            count = i;
        }            
        // WriteLine($"{sum}");                                        // для проверки сумм
        if (sum < min)                                              // Если сумма меньше min, переносим значение sum и count 
        {                                                           // в переменные вне цикла 
            min = sum;
            line = count;
        }
    }
    WriteLine($"Строка с наименьшей суммой элементов - {line + 1}");
}
int[,] table = GetArray(5, 4, 1, 9);
PrintArray(table);
LowerSumm(table);