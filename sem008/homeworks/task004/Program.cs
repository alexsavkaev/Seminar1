// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
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
int[,,] GetBlock(int tables, int lines, int columns) // Функция для создания массива по вводимым требованиям
{
    int[] numbers = new int[90];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = 10 + i;
    }
    int[,,] result = new int[tables, lines, columns];
    for (int i = 0; i < tables; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                int t = new Random().Next(0, 90); 
                if (numbers[t] != 0)
                {
                    result[i, j, k] = numbers[t];
                    numbers[t] = 0;
                }
                else
                {
                    while (numbers[t] == 0)
                    {
                        t = new Random().Next(0, 90);
                    }
                    result[i, j, k] = numbers[t];
                    numbers[t] = 0;
                }
            }
        }
    }
    return result;
}
void PrintBlock(int[,,] inArray)                                     // Функция для вывода массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
                Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            WriteLine();
        }
        // WriteLine();
    }
}
void PrintArray(int[,,] inArray)                                     // Функция для вывода массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
                Write($"{inArray[i, j, k]} ");
            WriteLine();
        }
        // WriteLine();
    }
}

int tables = Prompt("Введите количество таблиц: ");
int lines = Prompt("Введите количество строк в таблицах: ");
int columns = Prompt("Введите количество столбцов в таблицах: ");
if (tables * lines * columns > 90)
{
    WriteLine("Не хватит уникальных двузначных чисел");
}
else
{
    int[,,] block = GetBlock(tables, lines, columns);
    PrintBlock(block);
    PrintArray(block);
}
