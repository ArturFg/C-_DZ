Console.WriteLine("Hello, World!  Задача 19.");

Console.Write("Введите пятизначное число что бы понять полидр ли это: ");
int polydrome = Convert.ToInt32(Console.ReadLine());

int divisionMax = polydrome / 10000;
int remainderMin = polydrome % 10;

int remainderMax = polydrome % 10000;
int divisionMin = remainderMax / 10;

int divisionAverage = divisionMin / 100;
int remainder = divisionMin % 10;

if(divisionMax == remainderMin && divisionAverage == remainder) Console.Write($"Число {polydrome} являеться полидром.");
else Console.Write("Это число не полидром. Спроси у гугла: полиндр это?");



