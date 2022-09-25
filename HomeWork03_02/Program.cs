// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите значение для Ax");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для Ay");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для Az");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для Bx");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для By");
int by = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение для Bz");
int bz = int.Parse(Console.ReadLine());

double length3D = Math.Sqrt((Math.Pow((bx-ax),2))+(Math.Pow((by-ay),2))+(Math.Pow((bz-az),2)));

Console.WriteLine($"Расстояние между двумя точка = {length3D}");