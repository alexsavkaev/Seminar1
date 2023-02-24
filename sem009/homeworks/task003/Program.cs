// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;
Console.Clear();
int Akkerman(int num1, int num2)                            // Функция Аккермана с двойной рекурсией
{
  if (num1 == 0)
    return num2 + 1;                                        // Когда n = 0, возвращаем результат 
  else
    if ((num1 != 0) && (num2 == 0))
      return Akkerman(num1 - 1, 1);                         // Когда m = 0, начинаем уменьшать n
    else
      return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));  // Уменьшаем m до 0 
}
int Prompt(string message)                                  // Функция для ввода переменных
{
    Write(message);                                         // выводим заданный текст на экран
    string readInput = ReadLine();                          // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
int number1 = Prompt("Введите число m: ");
int number2 = Prompt("Введите число n: ");
Write($"A({number1},{number2}) = {Akkerman(number1, number2)}");