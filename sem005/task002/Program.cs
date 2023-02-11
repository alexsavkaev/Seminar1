/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();
int[] RndArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int[] RevolveArray(int[] mas)
{    
    for(int i = 0; i < mas.Length; i++)
    {
       mas[i] *= -1;
    }
    return mas;
}
int[] array = RndArray(4, -10, 10);
// RevolveArray(array2);
Console.WriteLine(String.Join(" ,", array));
Console.WriteLine(String.Join(" ,", RevolveArray(array)));

