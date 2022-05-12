Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()??"0");
if(a>99&&a<1000)
{
    Console.WriteLine($"Последняя цифра этого числа={a%10}");
}
else
{
    Console.WriteLine("Это число - не трехзначное!");
}
