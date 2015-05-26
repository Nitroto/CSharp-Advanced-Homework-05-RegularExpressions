using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

/// Write a program that reads a keyword and some text from the console and prints all sentences from the text, 
/// containing that word. A sentence is any sequence of words ending with '.', '!' or '?'.

class SentenceExtractor
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string wordMatch = Console.ReadLine();
        string wordRegex = @"\b" + wordMatch + @"\b";
        string userInput = Console.ReadLine();
        while (userInput != string.Empty)
        {
            MatchCollection output = Regex.Matches(userInput, @"(?<=(^|[.!?]\s*))[^ .!?][^.!?]+[.!?]");
            foreach (Match sentence in output)
            {
                string currebtSebtebce = sentence.Value;
                Match matchWord = Regex.Match(sentence.Value, wordRegex, RegexOptions.IgnoreCase);
                if (matchWord.Success)
                {
                Console.WriteLine("{0}", sentence);
                }
            }
            userInput = Console.ReadLine();
        }
    }
}
