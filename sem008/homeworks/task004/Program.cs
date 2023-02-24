// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;
Clear();
int Prompt(string message)                                    // Функция для ввода переменных
{
    Write(message);                                           
    string readInput = ReadLine();                            
    int result = int.Parse(readInput);                        
    return result;
}
int[,,] GetBlockOfUniques(int tables, int lines, int columns) // Функция для создания массива по вводимым требованиям
{
    int[] numbers = new int[90];                              // Создаём пул чисел по порядку 10-99
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = 10 + i;
    }
    int[,,] result = new int[tables, lines, columns];         // Создвём массив по введённым параметрам.
    for (int i = 0; i < tables; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                int t = new Random().Next(0, 90);             // Создаём случайное число
                if (numbers[t] != 0)                          // если элемент пула не обнулён:
                {                                             //
                    result[i, j, k] = numbers[t];             // присваиваем каждому элементу массива случайный элемент из пула чисел
                    numbers[t] = 0;                           // обнуляем элемент в пуле чисел
                }
                else
                {
                    while (numbers[t] == 0)                   // Если элемент уже обнулён (или находится в череде обнулённых):
                    {
                        if (t == numbers.Length - 1) t = 0;   // если это последний элемент массива, обнуляем t
                        t++;                                  // и движемся по возрастанию
                    }
                    result[i, j, k] = numbers[t];             // наткнувшись на необнулённый элемент, забираем его в массив
                    numbers[t] = 0;                           // и обнуляем
                }
            }
        }
    }
    return result;
}
void PrintBlock(int[,,] inArray)                              // Функция для вывода массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
                Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            WriteLine();
        }
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
    int[,,] block = GetBlockOfUniques(tables, lines, columns);
    PrintBlock(block);
}


