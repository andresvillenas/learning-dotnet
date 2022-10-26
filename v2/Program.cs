Console.WriteLine("1st method with C#");

int SumTwoIntegers(int x, int y)
{
    return x + y;
}

int x = 2, y = 7;

var sum = SumTwoIntegers(x, y);

Console.WriteLine($"{x}+{y}={sum}");
Console.WriteLine("🎊");