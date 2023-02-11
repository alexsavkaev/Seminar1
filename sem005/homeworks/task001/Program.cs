/*Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5
*/
Console.Clear();
int[] GetArray(int length, int minValue, int maxValue)      // Функция для создания массива (длина, минимальное значение, максимальное значение)
{
    int[] array = new int[length];
        for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}
int[] array = GetArray(123, 0, 1000);        // создаём массив с нужными параметрами
int CheckRange(int[] mas)                    // Функция для проверки массива на заданный диапазон
{
    int check = 0;                          // переменная счётчик   
    foreach(var el in mas)
    {
        check += el >= 10 && el <= 99 ? 1 : 0;  // прибавляем к счётчику +1 за каждый элемент массива, в диапазоне
    } 
    return check;
}                  
Console.WriteLine(String.Join(", ", array)); // выводим массив
Console.WriteLine($"Чисел в диапазоне 10-99: {CheckRange(array)}");  // Выводим результат            