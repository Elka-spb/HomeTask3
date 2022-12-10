// task 21
Console.Clear();
Console.Write("Введите координату Х 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z 1 точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Х 2 точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z 2 точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками в пространстве: " + 
Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2));