// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using static System.Console;
Console.Clear();
double Prompt(string message)                               // Функция для ввода данных в строку
{
    Write(message);
    double number = double.Parse(ReadLine());
    return number;
}
double[] GetCrossing(double nb1, double nk1, double nb2, double nk2)
{
    double x = (nb2 - nb1) / (nk1 - nk2);                   // Находим x пересечения
    double y = nk2 * x + nb2;                               // Находим y пересечения
    double[] result = new double[2];                        // Массив для вывода результата
    result[0] = x;
    result[1] = y;
    return result;
}
bool IsOneOrParallel(double nb1, double nk1, double nb2, double nk2)// Если соответствующие точки прямых совпадают -
{                                                                   // - значит оба уравнения описывают одну прямую
    if ((nb1 == nb2 && nk1 == nk2) || nk1 == nk2) return true;      // Если k1 = k2 - уравнение не имеет решения (т.к. делить на 0 нельзя), 
    else return false;                                              // -> прямые не пересекаются, соответственно они параллельны.
}




double b1 = Prompt("Введите b1: ");
double k1 = Prompt("Введите k1: ");
double b2 = Prompt("Введите b2: ");
double k2 = Prompt("Введите k2: ");
if (IsOneOrParallel(b1, k1, b2, k2))
{
    WriteLine("Прямые совпадают, либо параллельны");
}
else
{
    double[] crossing = GetCrossing(b1,k1,b2,k2);
    WriteLine($"Прямые пересекаются в точке: ({crossing[0]:f1}:{crossing[1]:f1})");
}


