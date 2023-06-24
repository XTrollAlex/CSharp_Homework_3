// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координаты X,Y,Z первой точки через запятую: ");
int[] aPoint = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

System.Console.Write("Введите координаты X,Y,Z второй точки через запятую: ");
int[] bPoint = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bPoint[0] - aPoint[0]), 2) + Math.Pow((bPoint[1] - aPoint [1]), 2) + Math.Pow((bPoint[2] - aPoint[2]), 2)), 2));