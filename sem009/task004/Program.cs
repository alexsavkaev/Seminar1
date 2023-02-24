// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

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

int Exponention(int n1, int n2)
{
    if (n2 == 0) return 1;
    if (n2 == 1) return n1;
    return (n1 * Exponention(n1, n2 - 1));

}
int number1 = Prompt("Введите число: ");
int number2 = Prompt("Введите степень: ");
WriteLine($"{number1} в степени {number2} = {Exponention(number1, number2)}");