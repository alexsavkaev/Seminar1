// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
using System;
using static System.Console;
Console.Clear();
double[,] GetArray(int lines, int columns, double minValue, double maxValue) // Функция для создания массива по вводимым требованиям
{
    double[,] result = new double[lines, columns];                           
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble()*(maxValue - minValue)+minValue;
        }
    }
    return result;
}
void PrintArray(double[,] inArray)                              // Функция для вывода массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f1} ");                   // Вывод числа с одним знаком после запятой
        }
        WriteLine();
    }
}
double PromptDouble(string message)                         // Функция для ввода данных в строку
{
    Write(message);
    double number = double.Parse(ReadLine());
    return number;
}
int PromptInt(string message)                               // Функция для ввода данных в строку
{
    Write(message);
    int number = int.Parse(ReadLine());
    return number;
}


int m = PromptInt("Введите количество строк массива(m): ");
int n = PromptInt("Введите количество столбцов массива(n): ");
double min = PromptDouble("Введите минимальное значение элемента: ");
double max = PromptDouble("Введите максимальное значение элемента: ");
double[,] array = GetArray(m, n, min, max);
PrintArray(array);

