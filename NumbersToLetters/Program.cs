using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersToLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" , "27" , "28", "29"})); // string expected = "codewars";
            Console.WriteLine(Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" })); //string expected = "btswmdsbd kkw";

        }

        //Given an array of numbers(in string format), you must return a string. 
        //The numbers correspond to the letters of the alphabet in reverse order: a=26, z=1 etc.
        //You should also account for '!', '?' and ' ' that are represented by '27', '28' and '29' respectively.

        public static string Switcher(string[] x)
        {
            var resList = new List<char>();
            foreach(var item in x)
            {
                if (int.Parse(item) <= 26) resList.Add((char)(26 - int.Parse(item) + 97));
                if (int.Parse(item) == 27) resList.Add('!');
                if (int.Parse(item) == 28) resList.Add('?');
                if (int.Parse(item) == 29) resList.Add(' ');
            }
            return string.Join("", resList);
        }
        // public static string Switcher(string[] x) => string.Concat(x.Select(n => "zyxwvutsrqponmlkjihgfedcba!? "[int.Parse(n) - 1]));
        // public static string Switcher(string[] x) => x.Aggregate("", (r, n) => r + "_zyxwvutsrqponmlkjihgfedcba!? "[int.Parse(n)]);
        // return string.Join("", x.Where(x => int.Parse(x)<= 26).Select(x => (char)(26 - int.Parse(x) + 97)).ToArray());


       // string switches = "zyxwvutsrqponmlkjihgfedcba!? ";
       //return string.Concat(x.Select(e => switches[int.Parse(e) - 1]));    


        //var alphabet = "zyxwvutsrqponmlkjihgfedcba!? ";
        //var res = string.Empty;
        //foreach (var a in x)
        //{
        //    res += alphabet[int.Parse(a) - 1];
        //}
        
        //return res;
    }
}
