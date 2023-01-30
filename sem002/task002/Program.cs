// Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine($"Число = {num}");
int num1 = num / 100 * 10;
int num2 = num % 10;
Console.WriteLine($"Результат = {num1 + num2}");