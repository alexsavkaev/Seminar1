// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
int Prompt (string message)                              // Функция для указаний пользователю
{
    Console.Write(message);                                 // выводим заданный текст на экран
    string readInput = Console.ReadLine();                  // считываем введённые данные в строку
    int result = int.Parse(readInput);                      // переводим строку в числа
    return result;
}

int ab = Prompt("Введите длину стороны ab: ");
int bc = Prompt("Введите длину стороны bc: ");
int ca = Prompt("Введите длину стороны ca: ");
bool TriangleCheck(int a, int b, int c)
{
    return ((a < (b + c)) && (b < (a + c)) && (c < (a + b)));   
}
if(TriangleCheck(ab, bc, ca))
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
