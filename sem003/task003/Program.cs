// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
Console.Clear();
Console.Write("Ведите x координату A: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Ведите y координату A: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Ведите x координату B: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Ведите y координату B: ");
int by = int.Parse(Console.ReadLine());


double s = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
// double s = Math.Sqrt((ax - bx)*(ax - bx) + (ay - by)*(ay - by));
Console.WriteLine($"{s:f3}");