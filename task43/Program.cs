﻿/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("введите число k1");
double k1 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("введите число k2");
double k2 = double.Parse(Console.ReadLine() ?? "");

double numberX = (b2 - b1) / (k1 - k2);
double numberY = k2 * numberX + b2;

Console.WriteLine($"Точка пересечения двух прямых: [{numberX};{numberY}]");