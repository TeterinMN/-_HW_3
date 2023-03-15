Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write($"По оси x: "); double x1 = double.Parse(Console.ReadLine()!);
Console.Write($"По оси y: "); double y1 = double.Parse(Console.ReadLine()!);
Console.Write($"По оси z: "); double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки:");
Console.Write($"По оси x: "); double x2 = double.Parse(Console.ReadLine()!);
Console.Write($"По оси y: "); double y2 = double.Parse(Console.ReadLine()!);
Console.Write($"По оси z: "); double z2 = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine("Расстояние между двумя точками: " + Math.Round(distance, 2));