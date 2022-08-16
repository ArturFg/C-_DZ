Console.WriteLine("Hello, World!");

int TwoNum(int num)
{
    num = num / 10;
    int two = num % 10;
    return two;
}

Console.Write("Введите число трёхзначное: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 999)
{
    Console.Write("Ошибка! В числе больше трёх цыфр. Напишите число в котором три цифры.");
}
else if(number < 100)
{
    Console.Write("Ошибка! В числе меньше трёх цыфр. Напишите число в котором три цыфры.");
}
else
{
    int con = TwoNum(number);
    Console.WriteLine($"Вторая цыфра числа {number}: {con}.");
}

