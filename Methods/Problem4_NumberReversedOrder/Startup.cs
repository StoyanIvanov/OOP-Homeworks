using System;
using System.Globalization;
using System.Linq;

namespace Problem4_NumberReversedOrder
{
    public class Startup
    {
        public static void Main()
        {
            int integerNumber;
            double doubleNumber;
            string reversedNumber;
            var input = Console.ReadLine();

            if (int.TryParse(input, out integerNumber))
            {
                reversedNumber = DecimalNumber.ReverseNumbers(int.Parse(input));
            }
            else
            {
                reversedNumber = DecimalNumber.ReverseNumbers(double.Parse(input, CultureInfo.InvariantCulture));
            }

            Console.WriteLine(reversedNumber);
        }
    }

    public class DecimalNumber
    {

        public static string ReverseNumbers(int number)
        {
            var result=new string(number.ToString().Reverse().ToArray());
            return result;
        }

        public static string ReverseNumbers(double number)
        {
            var result = new string(number.ToString(CultureInfo.InvariantCulture).Reverse().ToArray());
            return result;
        }

    }
}
