using System;
using System.Linq;

Console.WriteLine("This is the Password Checker");
Console.Write("Please input a password:");
string password= Console.ReadLine();


static string CheckPassword(string s, string password)
{
    if (s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit) && s.Any(char.IsSymbol) && password.Length == 14){ 
        Console.WriteLine("Good Password! :) A++");
    }
    else
    {
        Console.WriteLine("Bad Password! :( Make a better one");
    }
}

CheckPassword(password, password);
