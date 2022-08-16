Console.WriteLine("Hello, World!");

int ThreeNum(int num)
{
    while(num >= 999)
    {
        num = num / 10;
    }
    int three = num % 10;
    return three;
}

Console.Write("Введите число трёхзначное и более: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 99)
{
    Console.Write("Ошибка! Третьей цыфры ненайдено. Напишите число в котором три и более цифры.");
}
else
{
    int con = ThreeNum(number);
    Console.WriteLine($"Третья цыфра числа {number}: {con}.");
}
