/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9*/

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
int SummDigits(int num)
{
    if(num==0)
    {
        return 0;
    }
    return(SummDigits(num / 10) + num%10);
     
}
int number = Prompt("Введите число: ");
WriteLine($"{SummDigits(number)}");