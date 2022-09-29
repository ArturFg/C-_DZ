/*34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Hello, World! Задача №34");

int[] SizeNr(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arrays[i] = rnd.Next( 100, 1000); 
    }
    return arrays;
}

void CountEvenNumbers(int[] array)
{
    int coEv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            coEv++;
        }
    }
    Console.WriteLine($"Колличество чётных чисел в массиве: {coEv}.");
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
    CountEvenNumbers(res);
}
else Console.WriteLine("Ошибка ввода! Введите положительное число.");