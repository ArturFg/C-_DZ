Console.WriteLine("Hello, World! Задача 23.");

Console.Write("Введите число у которого хотите узнать квадраты: ");
int ctwo = Convert.ToInt32(Console.ReadLine());

int schet = ctwo + 1;
int index = 1;

while(index < schet)
{
    int number = index * index * index;
    Console.WriteLine(number);
    index++;
}

