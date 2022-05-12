Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");
int max = a;
int min = b;
if (a>b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Максимальное число={max}");
Console.WriteLine($"Минимальное число={min}");
