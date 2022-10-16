/*Задача 60. 
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void FillArrayDimensional(int[,,] matr)
{
    int nonRepeating = 10;
    for (int x = 0; x < matr.GetLength(0); x++) 
    {
        for (int y = 0; y < matr.GetLength(1); y++) 
        {
           for (int z = 0; z < matr.GetLength(2); z++) 
            {
                if(nonRepeating < 100)
                {
                    matr[x, y, z] = nonRepeating;
                    nonRepeating++;
                }
            }
        }
    }
}

void PrintArrayDimensional(int[,,] matr)
{
    for (int x = 0; x < matr.GetLength(0); x++) 
    {
        for (int y = 0; y < matr.GetLength(1); y++) 
        {
           for (int z = 0; z < matr.GetLength(2); z++) 
            {
               Console.Write($"{matr[x, y, z]} ({x}, {y}, {z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Hello, World! Задача №60");

Console.Write("Введите число, что бы зафиксировать количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать количество столбцов: ");
int сolumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать размер высоты: ");
int height = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[line, сolumn, height];

FillArrayDimensional(array);
PrintArrayDimensional(array);
