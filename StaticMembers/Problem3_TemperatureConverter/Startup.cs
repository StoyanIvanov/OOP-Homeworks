using System;
using System.Collections.Generic;
using System.Globalization;

namespace Problem3_TemperatureConverter
{
    public class Startup
    {
        public class TemperatureConverter
        {
            public static string Convert(string input)
            {
                var elements = input.Trim().Split();

                if (elements[1]== "Celsius")
                {
                    int celsiusTo = int.Parse(elements[0]);
                    double fahrenheitFrom = (celsiusTo * 1.8) + 32;
                    return $"{fahrenheitFrom.ToString("#.#0",CultureInfo.InvariantCulture)} Fahrenheit";
                }

                int fahrenheitTo = int.Parse(elements[0]);
                double celsiusFrom = (fahrenheitTo - 32)/1.8;
                return $"{celsiusFrom.ToString("#.#0", CultureInfo.InvariantCulture)} Celsius";
            }
        }

        public static void Main()
        {
            List<string> result=new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine=="End")
                {
                    break;
                }

                result.Add(TemperatureConverter.Convert(inputLine));
            }

            foreach (var temperature in result)
            {
                Console.WriteLine(temperature);
            }
        }
    }
}
