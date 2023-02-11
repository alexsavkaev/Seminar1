// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21

Console.Clear();
int Prompt (string message)                                 // Функция для указаний пользователю
{
    Console.Write(message);                                 // выводим заданный текст на экран
    string readInput = Console.ReadLine();                  // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
int[] GetArray(int length, int minValue, int maxValue)      // Функция для создания массива (длина, минимальное значение, максимальное значение)
{
    int[] array = new int[length];                          // Создаём массив с длинной length
        for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);// присваиваем каждому элементу массива значение в переделах заданного диапазона
    }
    return array;
}
int[] MultiplyPairs(int[] mas)                              // Функция для умножения пар
{
    int[] result = new int[mas.Length / 2];                 // создание буферного массива
    if(mas.Length % 2 != 0)                                 // проверка на чётное количество элементов массива
    {
        result = new int[mas.Length / 2 + 1];               // если не чётное количество - увеличиваем длину массива на 1
        result[result.Length - 1] = mas[mas.Length / 2];    // и записываем в последнюю позицию буферного массива средний элемент исходного
    }
    for(var i = 0; i < mas.Length / 2; i++)                 // перебираем элементы массива до середины
    {
        result[i] = mas [i] * mas[mas.Length - 1 - i];      // перемножаем соответствующие пары и записываем в буферный массив

    }
    return result;
}
int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальный диапазон массива: ");
int max = Prompt("Введите максивальный диапазон массива: ");
int[] array = GetArray(length, min, max);
Console.WriteLine(String.Join(", ", array));                // выводим исходный массив
Console.WriteLine(String.Join(", ", MultiplyPairs(array))); // выводим результат