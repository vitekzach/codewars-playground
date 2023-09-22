//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
int Persistence(long n)
{
    int count = 0;

    while (n >= 10)
    {
        count++;

        long sum = 1;
        while (n > 0)
        {
            sum *= n % 10;
            n /= 10;
        }

        n = sum;
    }

    return count;
}

var intsToTry = new List<long>() { 39, 999, 4 };
foreach (long toTry in intsToTry)
{
    Console.WriteLine($" Tried: {toTry}, result: {Persistence(toTry)}");
}
