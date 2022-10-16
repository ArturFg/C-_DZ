/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{b} " + NumbersRec(a, b - 1);
    else return String.Empty;
}

Console.WriteLine("Hello, World! Задача №64");

Console.Write("Введите число, от которого хотите увидеть убывание: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbersRec(1, n));
