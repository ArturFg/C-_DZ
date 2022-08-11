/*git remote add origin https://github.com/ArturFg/C-_DZ.git
git branch -M main
git push -u origin main*/

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else if (a == b)
{
    Console.WriteLine($"Числа {a} и {b} ровны.");
}
else
{
    Console.WriteLine($"max = {b}");
}
