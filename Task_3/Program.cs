Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");
int c = int.Parse(Console.ReadLine()??"0");
int max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.WriteLine($"Максимальное число={max}");
