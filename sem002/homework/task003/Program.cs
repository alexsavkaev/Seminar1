// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру, обозночающую день недели");
int num = int.Parse(Console.ReadLine());
// Цикл while для того, чтобы не программа не завершалась после ввода числа вне диапазона 1-7
while(num < 1 || num > 7)
{
    Console.WriteLine("от 1 до 7, пожалуйста");
    num = int.Parse(Console.ReadLine());
}
if (num == 6 || num == 7)
{
    Console.Write("Выходной");
}
else
{
    Console.Write("Опять работать :(");
}

// Решение через if
// if(num < 1 || num > 7)
// {
//     Console.WriteLine("от 1 до 7, пожалуйста");
// }
// else if (num == 6 || num == 7)
// {
//     Console.Write("Выходной");
// }
// else
// {
//     Console.Write("Опять работать :(");
// }