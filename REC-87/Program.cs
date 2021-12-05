using System;
using System.Linq;

namespace REC_87
{
    class Program
    {
        static String IsPalindrome(string Str)
        {
            Str = System.Text.RegularExpressions.Regex.Replace(Str, @"[\.!,\s:;?]", "");
            Str = Str.ToLower();
            if (Str == new string(Str.Reverse().ToArray()))
                return "полиндром.";
            else
                return "не полиндром.";
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Console.Write($"Введённая строка - {IsPalindrome(Console.ReadLine())}");
            Console.ReadKey();
        }
    }
}
