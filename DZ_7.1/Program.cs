/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void FillArrayDimensional(double[,] matr)
{
    Random random = new Random();
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            matr[rows, columns] = random.NextDouble() * 11;
        }
    }
}

void PrintArrayDimensional(double[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]}"); // Я забыл как уберать ненужные числа с конца.
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Hello, World! Задача №47");

Console.Write("Введите число, что бы зафиксировать количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать количество столбцов: ");
int сolumn = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[line, сolumn];
FillArrayDimensional(array);
Console.WriteLine($"Mассив: ");
PrintArrayDimensional(array);
Console.WriteLine();
