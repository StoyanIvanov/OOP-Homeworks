using System;

namespace Problem6_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine());
            Number number=new Number(inputNumber);

            Console.WriteLine(number.NextPrimeNumber());
        }
    }

    public class Number
    {
        private int number;
        private bool isPrime;

        public Number(int number)
        {
            this.number = number;
            isPrime = IsPrime(number);

        }

        public string NextPrimeNumber()
        {
            if (number==0)
            {
                return "1, true";
            }

            if (number==1)
            {
                return "2, true";
            }

            string resultString = "";
            for (int i = number+1; i < int.MaxValue; i++)
            {
                if (IsPrime(i)==true)
                {
                    resultString += i;
                    break;

                }
            }
            resultString += ", " + isPrime.ToString().ToLower();
            return resultString;
        }

        private bool IsPrime(int number)
        {
            bool result;
            int boundary = (int)Math.Floor(Math.Sqrt(number));
            result = true;
            if (number == 1) result = false;
            if (number == 2) result = true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) result = false;
            }

            return result;
        }
    }
}
