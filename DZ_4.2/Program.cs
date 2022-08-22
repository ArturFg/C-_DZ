Console.WriteLine("Hello, World! Задача 27.");

int SizeVon(int number)
{
    int si = 1;
    while(number >= 9)
    {
        number /= 10;
        si++;
    }
    return si;
}
int SumNum(int nu,int check)
{
    int sum = 0;
    for (int i = 0; i < check; i++)
    {
        int preserva = nu;
        int division = preserva / 10;
        int remainder = nu % 10;
        sum = sum + remainder;
        nu = division;
    }
    return sum;
}

Console.Write("Введите число чтобы определить сумму его цыфр: ");
int num = Convert.ToInt32(Console.ReadLine());

int size = SizeVon(num);
int answer = SumNum(num, size);

Console.WriteLine($"Сумма цыфр числа {num} = {answer}.");
