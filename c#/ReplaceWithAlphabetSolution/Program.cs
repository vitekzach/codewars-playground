// https://www.codewars.com/kata/546f922b54af40e1e90001da

string AlphabetPosition(string text)
{
    return String.Join(' ', text.ToLower().Where(Char.IsLetter).Select(x => x - 'a' + 1));
}

var stringsToTry = new List<string>()
{
    "The sunset sets at twelve o' clock.",
    "The narwhal bacons at midnight."
};

foreach (string test in stringsToTry)
{
    Console.WriteLine($" {AlphabetPosition(test)}");
}
