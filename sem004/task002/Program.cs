// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int Count(int num)
{
    int count = 0;
    if (num < 0)
        num *= (-1);
    while (num > 0){
        count++;
        num /=10;
    }
    return count;
    
}
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"{Count(n)}");

