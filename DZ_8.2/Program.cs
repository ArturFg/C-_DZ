/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

void FindingMinSumElements(int[,] matr)
{
    int min = 0;
    int line = 0;
    for (int columns = 0; columns < matr.GetLength(1); columns++) {min += matr[0, columns];}
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        int temporary = 0;
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            temporary += matr[rows, columns];
        }
        if(min > temporary) 
        {
            min = temporary;
            line = rows;
        }
    }
    Console.WriteLine($"Строка №{line + 1}, Минимальная сумма элементов строки = {min}");
}

Console.WriteLine("Hello, World! Задача №56");
Console.WriteLine("Не вводите одинаковой величены строки и столбцы.");

Console.Write("Введите число, что бы зафиксировать количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать количество столбцов: ");
int сolumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, сolumn];

FillArrayDimensional(array);
PrintArrayDimensional(array);
Console.WriteLine();

if(line != сolumn) FindingMinSumElements(array);
else Console.WriteLine("Пожалуйста вводите разной величены строки и столбцы.");
