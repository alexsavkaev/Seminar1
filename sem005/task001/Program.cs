//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.


Console.Clear();
int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}
int[] array = GenerateArray(12, -9, 9);
int negative = 0;
int positive = 0;
foreach (int el in array)
{
    positive += el > 0 ? el : 0;
    negative += el < 0 ? el : 0;
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма отрицательных чисел: {negative}. Сумма положительных чисел: {positive}");

// int Prompt (string message)
// {
//     Console.Write(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }
// int length = Prompt("Длина массива: ");
// int min = Prompt("Минимальное значение для диапазона случайного числа: ");
// int max = Prompt("Максимальное значение для диапазона случайного числа: ");
// int SortNeg (int[] mass)
// {
//     int sum = 0;
//     for(int i =0; i < mass.Length; i++)
//     {
        
//         if(mass[i] < 0)
//         sum += mass[i];
//     }
//     return sum;
// }
// int SortPos (int[] mass)
// {
//     int sum = 0;
//     for(int i =0; i < mass.Length; i++)
//     {
        
//         if(mass[i] > 0)
//         sum += mass[i];
//     }
//     return sum;
// }