using System;
using System.Text.RegularExpressions;

/// Write a program to extract all email addresses from a given text. The text comes at the only input line. 
/// Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: 
/// •	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them.Examples 
/// of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of 
/// invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
/// •	<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters 
/// and can have hyphens '-' between the letters.Examples of hosts: "softuni.bg", "software-university.com", 
/// "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-".

class ExtractEmails
{
    static void Main()
    {
        Regex regex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        string userInput = Console.ReadLine();
        while (userInput != string.Empty)
        {
            MatchCollection output = regex.Matches(userInput);
            foreach (Match email in output)
            {
                Console.WriteLine("{0}", email);
            }
            userInput = Console.ReadLine();
        }
    }
}
