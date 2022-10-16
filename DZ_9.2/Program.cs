/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumRes(int a, int b)
{
    if(a == b) return b;
    else return a + SumRes(a - 1, b);
}

Console.WriteLine("Hello, World! Задача №66");

Console.Write("Введите число, от которого хотите увидеть убывание: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, до которого хотите увидеть убывание: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumRes(n, m));
