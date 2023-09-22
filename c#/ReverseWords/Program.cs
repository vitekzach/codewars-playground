// https://www.codewars.com/kata/5259b20d6021e9e14c0010d4



string ReverseWords(string str)
{
    // This will create an empty string if there are multiple spaces
    string[] words = str.Split(" ");
    var reversedWords = new List<string>();

    foreach (string word in words)
    {
        char[] wordChars = word.ToCharArray();
        Array.Reverse(wordChars);
        reversedWords.Add(new String(wordChars));
    }

    str = String.Join(' ', reversedWords);
    return str;
}

string toReverse = "One two three  found";
string reversed = ReverseWords(toReverse);
Console.WriteLine($"Original: {toReverse}");
Console.WriteLine($"Reversed: {reversed}");
