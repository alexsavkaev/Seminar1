// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
int GetSumm(int number)
{
    if(number < 0)
    {
        number *= -1;
    }
    int temp = 0;
   while (number > 0)
   {
        temp += number % 10;
        number /= 10;
   }
    return temp;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {n} = {GetSumm(n)}");