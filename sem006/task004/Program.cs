/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
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
int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return array;
}
string el = Prompt("Введите массив через пробел: ");
int[] array = StringToArray(el);
Console.WriteLine(String.Join(", ", array));                // выводим исходный массив
Console.WriteLine(String.Join(", ", CopyArray(array)));     // выводим результат