/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int HowManyPositive(int[] arr)
{
    int posi = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int temporary = 0;
        temporary = Convert.ToInt32(Console.ReadLine());
        arr[i] = temporary;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) posi++;
    }
    return posi;
}

Console.WriteLine("Hello, World! Задача №41");

Console.Write("Пажалуйсто напишите сколько цифр вы собираитесь написать: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

int positive = HowManyPositive(array);
Console.WriteLine($"Вы вписали {positive} положительных числа.");
