// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21

Console.Clear();
string Prompt (string message)                              // Функция для указаний пользователю
{
    Console.Write(message);                                 // выводим заданный текст на экран
    string readInput = Console.ReadLine();                  // считываем введённые данные в строку
    return readInput;
}
int[] StringToArray(string stringArray)                     // Функция для преобразования строки в массив
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // разбиваем строку, оставляя только числа
    int[] res = new int[nums.Length];                       // создаём числовой массив той же длины что и строка
    for(int i = 0; i < nums.Length; i++)                    // цикл для перебора элементов строки
    {
        res[i] = int.Parse(nums[i]);                        // каждый элемент переводится в числовое значение
    }
    return res;
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
string el = Prompt("Введите элементы массива через пробел: ");
int[] array = StringToArray(el);
Console.WriteLine(String.Join(", ", array));                // выводим исходный массив
Console.WriteLine(String.Join(", ", MultiplyPairs(array))); // выводим результат