// https://www.codewars.com/kata/526571aae218b8ee490006f4

int CountBits(int n)
{
    int bitCount = 0;

    while (n > 0)
    {
        // adds 1 to count when there's a 1 at the end
        bitCount += n & 1;

        // bit shift binary representation by 1 to the right
        n >>= 1;
    }
    return bitCount;
}

var listOfNumbersToTest = new List<int>() { 1, 2, 3, 4, 5, 10, 32, 33 };

foreach (int test in listOfNumbersToTest)
    Console.WriteLine($"  Bit count: {CountBits(test)}");
