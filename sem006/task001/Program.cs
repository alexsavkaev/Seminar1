//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)




int[] GetArray(int length, int minValue, int maxValue)      // Функция для создания массива (длина, минимальное значение, максимальное значение)
{
    int[] array = new int[length];
        for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}
int[] array = GetArray(8, 0, 10);        // создаём массив с нужными параметрами
int[] TurnArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
                array2[i] = array[array.Length - 1 -i];        
    }
    return array2;
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(String.Join(", ", TurnArray(array))); // выводим массив