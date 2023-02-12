// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int Prompt (string message)                                 // Функция для указаний пользователю
{
    Console.Write(message);                                 // выводим заданный текст на экран
    string readInput = Console.ReadLine();                  // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
int[] GetArr(int length, int minValue, int maxValue)        // Функция для создания массива (длина, минимальное значение, максимальное значение)
{
    int[] array = new int[length];
        for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}
int MinMaxDiff(int[] array)                                 // Функция для нахождения разницы между min и max
{                                   
    int min = array[0];                                     // переменная для минимального значения
    int max = array[0];                                     // переменная для максимального значения
    foreach(int el in array)                                // цикл для перебора всех значений массива
    {
        min = el < min ? el : min;                          // поиск min и max элементов массива
        max = el > max ? el : max;
    }
        return max - min;                                   // возвращаем разницу между найденными значениями
}
int len = Prompt("Введите длину массива: ");                // пользователь вводит длину массива
int minV = Prompt("Введите минимальное значение: ");        // пользователь вводит минимальное значение массива
int maxV = Prompt("Введите максимальное значение: ");       // пользователь вводит максимальное значение массива
int[] array = GetArr(len, minV, maxV);                      // создаём массив
Console.WriteLine(String.Join(", ", array));                // выводим массив 
Console.WriteLine($"Разница: {MinMaxDiff(array)}");         // выводим разницу между элементами