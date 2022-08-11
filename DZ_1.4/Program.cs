Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = 0;
//int end = n - 1;
while (size < n - 1)
{
    if (n % 2 == 0)
    {
        Console.Write($"{n}; ");
        n = n - 1;
    }
    else  

    {
        n = n - 1;
        Console.Write($"{n}; ");
        n = n - 1;
    }
}
