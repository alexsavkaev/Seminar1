// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8
Console.Clear();
Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine());
// if(number < 100 || number > 999){
//     Console.WriteLine("Введено неправильное число");
//     return;
// }
// int otvet = number % 10;
// Console.WriteLine($"3 цифра: {otvet}");
string number = Console.ReadLine();
string otvet = Convert.ToString(number[2]);
Console.WriteLine($"3 цифра: {otvet}");