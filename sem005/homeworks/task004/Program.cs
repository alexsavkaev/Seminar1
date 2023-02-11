// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
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
int SummNotEven(int[] array)                                // Функция для подсчёта элементов на нечётных позициях [1, 3, 5, ...]
{
    int sum = 0;                                            // объявляем счётчик
    for(int i = 0; i < array.Length; i++)                   // цикл для перебора позиций
    {
        if(i % 2 != 0)                                      // если индекс позиции не чётный, 
        {
            sum += array[i];                                // то его значение прибавляется в счётчиу
        } 
    }
    return sum;
}
int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальне значение: ");
int max = Prompt("Введите максимальное значение: ");
int[] array = GetArr(length, min, max);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма нечётных элементов: {SummNotEven(array)}");
