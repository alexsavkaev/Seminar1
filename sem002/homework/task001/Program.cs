// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
// цикл  while для того, чтобы программа не завершалась после ввода не трёхзначного числа
while (num < 100 || num > 999)
{
    Console.Write("Число не трёхзначное, попробуйте ещё раз: ");
    num = int.Parse(Console.ReadLine());
}
    int result = num / 10 % 10;
Console.Write($"{num} -> {result}");

// Решение через if
// if (num < 100 || num > 999)
// {
//     Console.Write("Число не трёхзначное");
// }
// else
// {
//     int result = num / 10 % 10;
// Console.Write($"{num} -> {result}");
// }


