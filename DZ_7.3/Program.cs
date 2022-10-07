/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void FillArrayDimensional(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            matr[rows, columns] = new Random().Next(1, 10);
        }
    }
}

void ArithmeticMeansOfaColumn(int[,] matr, int rolystvo)
{
    for (int columns = 0; columns < matr.GetLength(1); columns++) 
    {
        int number = 0;
        for (int rows = 0; rows < matr.GetLength(0); rows++) 
        {
            number += matr[rows, columns];
        }
        Console.WriteLine($"Средние арефмитическое столбца {columns + 1} = {number / rolystvo}. ");
    }
}

void PrintArrayDimensional(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Hello, World! Задача №52");
Console.WriteLine();

Console.Write("Введите число, что бы зафиксировать количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать количество столбцов: ");
int сolumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, сolumn];

FillArrayDimensional(array);
PrintArrayDimensional(array);
Console.WriteLine();

ArithmeticMeansOfaColumn(array, line);
