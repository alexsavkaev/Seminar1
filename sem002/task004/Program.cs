// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num % 7 != 0)
{
    Console.Write("Не Кратно");
    return;
}
if(num % 23 != 0)
{
    Console.Write("Не Кратно");
}
else
{
    Console.Write("Кратно");
}