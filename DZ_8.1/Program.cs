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

int[,] RowFromLargestToSmallest(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) 
    {
        int[] copySortingMax = new int[matr.GetLength(1)];

        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            copySortingMax[columns] = matr[rows, columns];
        }
        for (int i = 0; i < copySortingMax.Length - 1; i++)
        {
            int maxPosition = i;

            for (int j = i + 1; j < copySortingMax.Length; j++)
            {
                if(copySortingMax[j] > copySortingMax[maxPosition]) maxPosition = j;
            }

            int temporari = copySortingMax[i];
            copySortingMax[i] = copySortingMax[maxPosition];
            copySortingMax[maxPosition] = temporari;
        }
        for (int columns = 0; columns < matr.GetLength(1); columns++) 
        {
            matr[rows, columns] = copySortingMax[columns];
        }
    }
    return matr;
}

Console.WriteLine("Hello, World! Задача №54");
Console.WriteLine();

Console.Write("Введите число, что бы зафиксировать количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, что бы зафиксировать количество столбцов: ");
int сolumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, сolumn];

FillArrayDimensional(array);
PrintArrayDimensional(array);
Console.WriteLine();

RowFromLargestToSmallest(array);
PrintArrayDimensional(array);
