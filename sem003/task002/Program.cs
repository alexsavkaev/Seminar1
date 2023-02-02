// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите Номер четверти: ");
int quart = int.Parse(Console.ReadLine());


// if(quart == 1)
// {
//     Console.WriteLine("x > 0; y > 0");
// }else if(quart == 2)
// {
//     Console.WriteLine("x < 0; y > 0");
// }else if(quart == 3)
// {
//     Console.WriteLine("x < 0; y < 0");
// }else if(quart == 4)
// {
//     Console.WriteLine("x > 0; y < 0");
// }else if (quart > 4 || quart < 1)
// {
//     Console.WriteLine("Это не номер четверти");
// }

switch (quart)
{
    case 1:
    {
        Console.WriteLine("x > 0; y > 0");
       break; 
    }
    case 2:
    {
        Console.WriteLine("x < 0; y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x < 0; y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x > 0; y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Это не номер четверти");
        break;
    }
}