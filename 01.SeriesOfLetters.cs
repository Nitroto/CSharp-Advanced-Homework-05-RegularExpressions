using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

/// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

class SeriesOfLetters
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string output = Regex.Replace(input, @"(.)(\1)+", "$1");
        Console.WriteLine(output);
    }
}
