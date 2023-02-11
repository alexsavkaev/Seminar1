// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
int CountEven(int[] mas)                                    // Функция для подсчёта чётных чисел в массиве
{
    int counter = 0;                                        // создаём переменную для счёта
        foreach (int el in mas)                             // цикл для перебора элементов массива
    {
        result += el % 2 == 0 ? 1 : 0;                      // если элемент чётный - добавляем 1 к счётчику
    }
    return counter;
}
int length = Prompt("Введите длину массива: ");
int[] array = GetArr(length, 100, 999);
Console.WriteLine(String.Join(", ", array));                // выводим массив
Console.WriteLine($"Чётных чисел в массиве: {CountEven(array)}");// выводим результат