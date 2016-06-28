using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Problem3_LastDigitName
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var result=Number.LastNumberWord(inputLine);
            Console.WriteLine(result);

        }
    }

    public class Number
    {
        private static string[] numbersWord = new[] {"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        public static string LastNumberWord(string number)
        {
            var lastNumber = number[number.Length - 1].ToString();

            return numbersWord[int.Parse(lastNumber)];
        }
    }
}
