// Задача 25: Напишите цикл, который принимает
//  на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int GetExp(int num1, int num2)
{
    int result = 1;
    if(num1 > 1)
    {              
        for(int i = 0; i < num2; result *= num1, i++);        
    }
     return result;
}
Console.Write("Введите число 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {n1} в степени {n2} = {GetExp(n1,n2)}");
