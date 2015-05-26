using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

/// Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags 
/// [URL href=…]…[/URL]. Print the result on the console.
/// Note: The input may be read on a single line  or from a file.

class ReplaceATtag
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Original code:");
        using (StreamReader reader = new StreamReader(@"..\..\index.html"))
        {
            String line = String.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("\n\rCode after RegEx");
        using (StreamReader reader = new StreamReader(@"..\..\index.html"))
        {
            String line = String.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                string output = Regex.Replace(line, @"(?:<a\s)(.*?)>(.*?)(?:</a>)", @"[URL ${1}]${2}[/URL]");
                Console.WriteLine(output);
            }
        }
    }
}
