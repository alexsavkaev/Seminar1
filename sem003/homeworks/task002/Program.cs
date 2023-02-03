﻿// Задача 21

// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Ведите x координату точки A: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Ведите y координату точки A: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Ведите z координату точки A: ");
int az = int.Parse(Console.ReadLine());
Console.Write("Ведите x координату точки B: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Ведите y координату точки B: ");
int by = int.Parse(Console.ReadLine());
Console.Write("Ведите z координату точки B: ");
int bz = int.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
Console.WriteLine($"{s:f2}");