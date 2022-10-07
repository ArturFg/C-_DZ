/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void FillArrayDimensional(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            matr[rows, columns] = new Random().Next(-50, 100);
        }
    }
}

void NumberSearchArrayDimensional(int[,] matr, int number)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            if(number == matr[rows, columns])
            {
                Console.Write($"[{rows}, {columns}] -> {matr[rows ,columns]} ");
            }
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

//Версия №1

Console.WriteLine("Hello, World! Задача №50");
Console.WriteLine();

Console.Write("Введите номер строки: №");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: №");
int сolumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[25, 25];

if(line <= 25 && сolumn <= 25)
{
    FillArrayDimensional(array);
    PrintArrayDimensional(array);
    Console.WriteLine();
    Console.WriteLine(array[ line - 1, сolumn - 1]);
}
else Console.WriteLine("Вы ввели несуществуещее колличество столбцов или строк!");


//Версия №2

Console.WriteLine("Hello, World! Задача №50.1");

Console.Write("Введите число, что бы зафиксировать количество строк: ");
int line1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать количество столбцов: ");
int сolumn1 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[line1, сolumn1];
FillArrayDimensional(array1);
PrintArrayDimensional(array1);
Console.WriteLine();

Console.Write("Введите число каторое хотите найти в задонном вами массиве: ");
int findClean = Convert.ToInt32(Console.ReadLine());
NumberSearchArrayDimensional(array1, findClean);