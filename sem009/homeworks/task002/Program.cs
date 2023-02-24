// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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
int SummBetween(int m, int n)                               // Рекурсивная функция для подсчёта суммы чисел между m и n
{
    if (m == n) return m;

    return (m + SummBetween(m + 1, n));
}
int num1 = Prompt("Введите число M: ");
int num2 = Prompt("Введите число N: ");
Write($"Сумма чисел в промежутке {num1}-{num2} равна: {SummBetween(num1, num2)}");