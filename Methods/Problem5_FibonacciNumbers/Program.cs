
namespace Problem5_FibonacciNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= 0 && firstNumber <= secondNumber)
            {
                Fibonacci fibonacci = new Fibonacci(secondNumber);
                List<long> result = fibonacci.FibonacciNumbers(firstNumber, secondNumber);

                string resultString = "";
                for (int i = 0; i < result.Count; i++)
                {
                    if (i > 0)
                    {
                        resultString += ", ";
                    }
                    resultString += result[i];
                }
                Console.WriteLine(resultString);
            }
        }
    }

    public class Fibonacci
    {
        private List<long> fibunacciNumbers;

        public Fibonacci(long endNumber)
        {
            fibunacciNumbers = new List<long>();
            long num1 = -1;
            long num2 = 1;
            long sum = 1;
            for (long i = 0; i < endNumber; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                fibunacciNumbers.Add(num2);
            }
        }

        public List<long> FibonacciNumbers(int startNumber, int endNumber)
        {

            return fibunacciNumbers.GetRange(startNumber, endNumber-startNumber);
        }
    }
}
