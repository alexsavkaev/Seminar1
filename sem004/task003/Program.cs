// Напишите программу, которая принимает на 
// вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int GetMult(int limit)
{
    int mult = 1;
    for (int i = 2; i <= limit; i++)    
    {
        mult *= i;
    }
    return mult;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение от 1 до {n} равна {GetMult(n)}");

