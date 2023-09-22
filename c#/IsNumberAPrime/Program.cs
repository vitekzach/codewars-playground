// https://www.codewars.com/kata/5262119038c0985a5b00029f



bool IsPrime(int n)
{
    Console.WriteLine($"Testing for: {n}");
    if (n <= 2 || n % 2 == 0)
        return n == 2;

    int maxToTry = Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
    Console.WriteLine($"  Try up to: {maxToTry}");

    for (int i = 3; i <= maxToTry; i += 2)
    {
        Console.WriteLine($"  Trying i: {i}");
        if (n % i == 0)
            return false;
    }
    return true;
}

Console.WriteLine($"  {IsPrime(-10)}");
Console.WriteLine($"  {IsPrime(10)}");
Console.WriteLine($"  {IsPrime(100000)}");
Console.WriteLine($"  {IsPrime(11)}");
Console.WriteLine($"  {IsPrime(127)}");
Console.WriteLine($"  {IsPrime(2)}");
