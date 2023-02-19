// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
using System;
using static System.Console;
Console.Clear();
string Prompt(string message)                               // Функция для ввода данных в строку
{
    Write(message);
    string readInput = ReadLine();
    return readInput;
}
int[] StringToArray(string stringArray)                     // Функция для преобразования строки в массив
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // разбиваем строку, оставляя только числа
    int[] res = new int[nums.Length];                       // создаём числовой массив той же длины что и строка
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int IsPositive(int[] numbers)                               // Функция для проверки чисел на положительность
{
    int sum = 0;
    foreach (int el in numbers)                             // Цикл, перебирающий элементы массива..
    {
        sum += el > 0 ? 1 : 0;                              // .. и записывающий положительные числа в счётчик sum
    }
    return sum;
}

string inArray = Prompt("Введите числа через пробел: ");    // Вводим числа
int[] arrayNumbers = StringToArray(inArray);                // Преобразуем строку в массив
int result = IsPositive(arrayNumbers);                      // Проверяем на положительность
WriteLine($"Чисел больше нуля: {result}");                  // Выводим результат
