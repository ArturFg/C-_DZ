Console.WriteLine("Hello, World!");



Console.Write("Введите число, что бы зафиксировать размер массива: ");
int length = Convert.ToInt32(Console.ReadLine()); 



string[] arrays = new int[length];
for (int i = 0; i < length; i++)
{
    arrays[i] = Convert.ToInt32(Console.ReadLine()); 
}

int index = 0;
Console.Write($"[{mass[index]}, ");
for (int i = 1; i < mass.Length - 1; i++)
{
    Console.Write($"{mass[i]}, ");
}
Console.Write($"{mass[mass.Length - 1]}]");