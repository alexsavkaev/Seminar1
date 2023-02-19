// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
using static System.Console;
Console.Clear();
int Prompt(string message)                                  // Функция для ввода цифровых значений
{
    Write(message);                                         // выводим заданный текст на экран
    string readInput = ReadLine();                          // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
int[,] GetArray(int m, int n)                               // Функция для создания массива по числу строк и столбцов
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
void PrintArray(int[,] inArray)                             // Функция вывода массива в консоль
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
double[] ArithMean(int[,] inArray)                          // Функция для подсчёта ср. арифметического столбцов
{

    double[] result = new double[inArray.GetLength(1)];     // Задаём массив длиной равной длине строки(кол-ву столбцов)
    for (int i = 0; i < inArray.GetLength(1); i++)          
    {
        double sum = 0;                                     // Переменная для накопления сумм столбца
        for (int j = 0; j < inArray.GetLength(0); j++)      
        {
            sum += inArray[j, i];                           // Перебираем каждый столбец и прибавляем значение в сумму
        }
        result[i] = Math.Round((sum/inArray.GetLength(0)),1);// Делим сумму на количество строк
    }
    return result;

}
int lines = Prompt("Введите число строк: ");
int columns = Prompt("Введите число столбцов: ");
int[,] array = GetArray(lines, columns);
PrintArray(array);
Write($"Среднее арифмитическое столбцов массива равно {String.Join(" ", ArithMean(array))};");