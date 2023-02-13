// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10
Console.Clear();
int Prompt (string message)                              // Функция для указаний пользователю
{
    Console.Write(message);                                 // выводим заданный текст на экран
    string readInput = Console.ReadLine();                  // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}
string ToBinary(int num, int system)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (num > 0)
    {
        int ost = num / system;
        res = nums[num - system * ost] + res;
        num /= system;
    }
    return res;
}
int num = Prompt("Введите число: ");
int system = Prompt("В какую систему переводить: ");
Console.Write(ToBinary(num, system));