Console.WriteLine("Hello, World! Задача 21.");

Console.Write("Введите кординату x точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите кординату x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z точки A: ");
int zB = Convert.ToInt32(Console.ReadLine());

double root = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));

Console.WriteLine($"Расстояние между точкой A и точкой B: {Math.Round(root, 2, MidpointRounding.ToZero)}.");
