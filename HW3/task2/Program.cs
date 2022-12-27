using static System.Console;
Clear();

WriteLine("Для того, чтобы узнать расстояние между точками в пространстве введите их координаты.");
Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками = {distance:f2}");
