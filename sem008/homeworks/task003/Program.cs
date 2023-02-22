// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
using static System.Console;
Console.Clear();
int Prompt(string message)                                  // Функция для ввода переменных
{
    Write(message);                                         // выводим заданный текст на экран
    string readInput = ReadLine();                          // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
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
            Write($"{inArray[i, j]} ");                   
        }
        WriteLine();
    }
}
int[,] MulriplyMatrix(int [,] inArray1, int[,] inArray2)            // Функция перемножения матриц
{
    int[,] resultArray = new int[inArray1.GetLength(0), inArray1.GetLength(1)]; // Создаём матрицу, размером как исходные
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < resultArray.GetLength(0); k++)      // Для каждого элемента проходим по соответствующей строке
            {                                                       // первой матрицы и столбцу второй
                resultArray[i,j] += inArray1[i,k]*inArray2[k,j];    // Перемножаем элементы и прибавляем к уже записанному в элементе
            }            
        }
    }
    return resultArray;
}
int side = Prompt("Введите длину стороны матриц: ");
int[,] matrix1 = GetArray(side,side,1,9);
int[,] matrix2 = GetArray(side,side,1,9);
PrintArray(matrix1);
WriteLine();
PrintArray(matrix2);
WriteLine();
int[,] result = MulriplyMatrix(matrix1, matrix2);
PrintArray(result);