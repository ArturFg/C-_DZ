Console.Write("Введите число чтобы проверить на чётность: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"{n} - чётное.");
}
else
{
    Console.WriteLine($"{n} - нечётное.");
}
