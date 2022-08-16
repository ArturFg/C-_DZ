Console.WriteLine("Hello, World!");

Console.Write("Введите число недели чтобы узнать выходной это или нет: ");
int week = Convert.ToInt32(Console.ReadLine());

if(week == 1)
{
    Console.WriteLine("Это понидельник, он не выходной =( ");
}
else if(week == 2)
{
    Console.WriteLine("Это вторник, он не выходной =( ");
}
else if(week == 3)
{
    Console.WriteLine("Это среда, он не выходной =( ");
}
else if(week == 4)
{
    Console.WriteLine("Это четверг, он не выходной =( ");
}
else if(week == 5)
{
    Console.WriteLine("Это пятница, он не выходной =( ");
}
else if(week == 6)
{
    Console.WriteLine("Это суббота, он выходной!!! =D ");
}
else if(week == 7)
{
    Console.WriteLine("Это воскресенье, он выходной!!! =D ");
}
else
{
    Console.WriteLine("Это цыфра или число даже день недели не смволизирует, поэтому поставь цыфру от 1 - 7, а если тебя интересует выходной, то поставь 6 или 7.  ");
}
