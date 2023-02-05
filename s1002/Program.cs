namespace s1002;

public static class Program
{
        
    private static void Main()
    {
        // string[] tokens = Console.ReadLine().Split(' ');
        GetWord("7325189087", new [] { "it", "your", "reality", "real", "our"});
    }

    private static void GetWord(string phoneNumber, IEnumerable<string> words)
    {
        var digitWords = GetDigitWords(words);
        var text = "";
        var ret = "";
        for (var i = 0; i < phoneNumber.Length; ++i)
        {
            text += phoneNumber.Substring(i, 1);
            if (digitWords.ContainsKey(text))
            {
                ret += digitWords[text] + " ";
                text = "";
            }
        }
        
        Console.WriteLine(ret);
    }

    private static Dictionary<string, string> GetDigitWords(IEnumerable<string> words)
    {
        var digitWords = new Dictionary<string, string>();
        foreach (var word in words)
        {
            var digitWord = "";
            for (var i = 0; i < word.Length; ++i)
            {
                digitWord += GetNumber(word.Substring(i, 1));
            }

            digitWords[digitWord] = word; 
        }

        return digitWords;
    }

    private static char GetNumber(string inSymbol)
    {
        return inSymbol switch
        {
            "i" => '1',
            "j" => '1',
            "a" => '2',
            "b" => '2',
            "c" => '2',
            "d" => '3',
            "e" => '3',
            "f" => '3',
            "g" => '4',
            "h" => '4',
            "k" => '5',
            "l" => '5',
            "m" => '6',
            "n" => '6',
            "p" => '7',
            "r" => '7',
            "s" => '7',
            "t" => '8',
            "u" => '8',
            "v" => '8',
            "w" => '9',
            "x" => '9',
            "y" => '9',
            _ => '0'
        };
    }
}

