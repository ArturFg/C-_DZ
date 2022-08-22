Console.WriteLine("Hello, World! Задача 25.");

int PereMultiply(int o, int d)
{
    int num = o;
    for (int i = 1; i < d; i++)
    {
    num = num * o;
    }
    return num;
}

Console.Write("Введите число A, которое хотите пере множать: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B, для того чтобы определить сколько раз перемножать число A: ");
int b = Convert.ToInt32(Console.ReadLine());

int answer = PereMultiply(a, b);

Console.WriteLine($"Число {a} в степени {b} = {answer}.");
