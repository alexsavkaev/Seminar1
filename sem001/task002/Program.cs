Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}