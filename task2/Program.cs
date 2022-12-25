//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Вводим координаты первой точки");
Console.Write("Введем координату x1: ");
float x1 = float.Parse(Console.ReadLine()!);
Console.Write("Введем координату y1: ");
float y1 = float.Parse(Console.ReadLine()!);
Console.Write("Введем координату z1: ");
float z1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Вводим координаты второй точки");
Console.Write("Введем координату x2: ");
float x2 = float.Parse(Console.ReadLine()!);
Console.Write("Введем координату y2: ");
float y2 = float.Parse(Console.ReadLine()!);
Console.Write("Введем координату z2: ");
float z2 = float.Parse(Console.ReadLine()!);
float diff1 = x1 - x2;
float diff2 = y1 - y2;
float diff3 = z1 - z2;
float square1 = MathF.Pow(diff1, 2);
float square2 = MathF.Pow(diff2, 2);
float square3 = MathF.Pow(diff3, 2);
float sum = square1 + square2 + square3;
Console.WriteLine("Расстояние между точками равно: " +MathF.Round(MathF.Sqrt(sum),2));