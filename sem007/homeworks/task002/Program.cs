// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


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
string PromptStr(string message)                            // Функция для ввода текстовых значенийю
{
    Write(message);                                         // выводим заданный текст на экран
    string result = ReadLine();                             // считываем введённые данные в строку
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
int[] StringToArray(string stringArray)                     // Функция для преобразования строки в массив
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // разбиваем строку, оставляя только числа
    int[] res = new int[nums.Length];                       // создаём числовой массив той же длины что и строка
    for(int i = 0; i < nums.Length; i++)                    // цикл для перебора элементов строки
    {
        res[i] = int.Parse(nums[i]);                        // каждый элемент переводится в числовое значение
    }
    return res;
}
void CheckElement(int[,] tempArray, int[] tempId)           // Функция для проверки адреса элемента и его вывода
{
    if(tempId[0] > tempArray.GetLength(0) || tempId[1] > tempArray.GetLength(1))
    {
        WriteLine("Такого элемента не существует в массиве.");
    }
    else
    {
        WriteLine($"{tempArray[tempId[0]-1,tempId[1]-1]}");
    }

}
int lines = Prompt("Введите колиечство строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int[,] array = GetArray(lines, columns);
PrintArray(array);
string id = PromptStr("Введите адрес элемента через пробел: ");
int[] adress = StringToArray(id);
CheckElement(array, adress);