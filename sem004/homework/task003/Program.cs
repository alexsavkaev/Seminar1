// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int num = int.Parse(Console.ReadLine()); 
int[] array = GetRndArray(num);
Console.Write($"[{String.Join(", ", array)}]");
int[] GetRndArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(99);
    }
    return result;
}