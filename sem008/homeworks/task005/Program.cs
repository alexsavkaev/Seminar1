// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;
Clear();

int[,] SpiralFilling(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    int begI = 0;           // Точка начала прямоугольника движения по i
    int begJ = 0;           // Точка начала прямоугольника движения по j
    int endI = 0;           // Точка конца прямоугольника движения по i
    int endJ = 0;           // Точка конца прямоугольника движения по j
    int filler = 1;         // Переменная для заполнения элементов массива
    int i = 0;              // Индекс строк
    int j = 0;              // Индекс столбцов
    while (filler <= columns * lines)                                   // границы цикла = количество ячеек в массиве
    {
        result[i, j] = filler;                                          // Заполняем первую ячейку массива
        if (i == begI && j < columns - endJ - 1) j++;                   // пока мы находимся на верхней стороне, движемся  →→→
        else if (j == columns - endJ - 1 && i < lines - endI - 1) i++;  // пока мы находимся на правой стороне, движемся   ↓↓↓
        else if (i == lines - endI - 1 && j > begI) j--;                // пока мы находимся на нижней стороне, движемся   ←←←
        else i--;                                                       // в остальных случайх (правая сторона) - движемся ↑↑↑
        if ((i == begI + 1)                                             // если мы находимся строкой ниже начала прямоугольника
        && (j == begJ)                                                  // и если столбец совпадает с началом прямоугольника
        && (begJ != columns - endJ - 1))                                // и если столбец начала не в центре для массивов (7х3),(9х5) и т.д.
        {
            begI++;                                                     // Увеличиваем значение начал и концов прямоугольника, 
            endI++;                                                     // переходя на внутренний прямоугольник
            begJ++;
            endJ++;
        }
        filler++;                                                       // инкрементируем наполнитель
    }
    return result;
}
void PrintArray(int[,] inArray)                                         // Функция для вывода массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10) Write($"0{inArray[i, j]} ");        // Чтобы ряды ровно стояли, приписываем 0 перед числами до 10
            else Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
int Prompt(string message)                                              // Функция для ввода переменных
{
    Write(message);                                                     // выводим заданный текст на экран
    string readInput = ReadLine();                                      // считываем введённые данные в строку
    int result = int.Parse(readInput);                                  // переводим строку в числа
    return result;
}
int lin = Prompt("Введите число строк массива: ");
int col = Prompt("Введите число столбцов массива: ");
int[,] array = SpiralFilling(lin, col);
PrintArray(array);