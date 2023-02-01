// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();

long number1 = 0;
bool numbersOnly = long.TryParse(num, out number1);  // Проверяем, чтобы введённые данные были именно числами, а не текстом
if (numbersOnly == true)
{
    while(num.Length < 3)           // Цикл while для того, чтобы программа не завершалась после ввода не подходящего числа
{
    Console.WriteLine("Нет третьей цифры, попробуйте еще раз: ");
    num = Convert.ToString(Console.ReadLine());
}
Console.Write($"{num} -> {num[2]}");
}
else
Console.WriteLine("Введённые данные - не число");

// while(num.Length < 3)
// {
//     Console.WriteLine("Нет третьей цифры, попробуйте еще раз: ");
//     num = Convert.ToString(Console.ReadLine());
// }
// Console.Write($"{num} -> {num[2]}");

// Решение через if
// if (num.Length < 3)
// {
//     Console.Write("Нет третьей цифры.");
// }
// else
// {
//     Console.Write($"{num} -> {num[2]}");
// }

    

