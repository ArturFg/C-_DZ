/*36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Hello, World! Задача №36");

int[] SizeNr(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arrays[i] = rnd.Next( -99, 100); 
    }
    return arrays;
}

void SumOfOddElements(int[] array)
{
    int soe = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            soe += array[i];
        }
    }
    Console.WriteLine($"Сумма чисел стаящих на нечётных позицыях в массиве: {soe}.");
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
    SumOfOddElements(res);
}
else Console.WriteLine("Ошибка ввода! Введите положительное число.");
