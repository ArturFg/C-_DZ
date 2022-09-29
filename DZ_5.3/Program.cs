/*38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Hello, World! Задача №38");

int[] SizeNr(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arrays[i] = rnd.Next( 1, 100); 
    }
    return arrays;
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporari = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporari;
    }
}

void DifferenceMinMax(int[] arr, int max)
{
    int dmm = arr[max - 1] - arr[0];
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {dmm}.");
}

void PrintArray(int[] mass)
{
    int index = 0;
    Console.Write($"[{mass[index]}, ");
    for (int i = 1; i < mass.Length - 1; i++)
    {
        Console.Write($"{mass[i]}, ");
    }
    Console.Write($"{mass[mass.Length - 1]}]");
}

Console.Write("Введите число, что бы зафиксировать размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());   

if(length > 0)
{
    int[] res = SizeNr(length);
    Console.Write("Массив: ");
    PrintArray(res);
    Console.WriteLine();
    SelectionSort(res);
    DifferenceMinMax(res, length);
}
else Console.WriteLine("Ошибка ввода! Введите положительное число.");