/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void LineIntersection(int a1, int a2, int c1, int c2)
{
    c1 = -c1;
    a2 = -a2;

    int a3 = a1 + a2;
    int c3 = c2 + c1;
    int x = c3 * a3;

    c1 = -c1;
    a2 = -a2;
    int y = a1 * x + c1;
    int y1 = a2 * x + c2;

    if(y == y1) Console.WriteLine($"(x = {x}; y = {y})");
    else Console.WriteLine("Координата y первой и второй премых неравны!");
}

Console.WriteLine("Hello, World! Задача №43");
Console.WriteLine();

Console.WriteLine("Введите число координаты первой примой показанные на примере: ");
Console.Write("y = _x + ? -> ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"y = {k1}x + _ -> ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число координаты второй примой показанные на примере: ");
Console.Write("y = _x + ? -> ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"y = {k2}x + _ -> ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(k1 != k2) LineIntersection(k1, k2, b1, b2);
else Console.WriteLine("У вас паралельные прямые.");
