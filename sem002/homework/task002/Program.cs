// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string num = Convert.ToString(Console.ReadLine());
// Цикл while для того, чтобы программа не завершалась после ввода не подходящего числа
while(num.Length < 3)
{
    Console.WriteLine("Нет третьей цифры, попробуйте еще раз: ");
    num = Convert.ToString(Console.ReadLine());
}
Console.Write($"{num} -> {num[2]}");

// Решение через if
// if (num.Length < 3)
// {
//     Console.Write("Нет третьей цифры.");
// }
// else
// {
//     Console.Write($"{num} -> {num[2]}");
// }

    

