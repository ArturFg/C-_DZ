Console.WriteLine("Hello, World! Задача 29.");

int[] SizeNr(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = rnd.Next( 1, 100); 
    }
    return arrays;
}
void PrintArray(int[] res1)
{
    Console.Write("[");
    for (int i = 0; i < res1.Length -1; i++)
    {
        Console.Write($"{res1[i]}, ");
    }
    Console.Write($"{res1[res1.Length]}]"); //Почимуто сама программа работает, а этот код нет...?
}

Console.Write("Введите число, что бы зафиксировать размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] res = SizeNr(length);
PrintArray(res);
