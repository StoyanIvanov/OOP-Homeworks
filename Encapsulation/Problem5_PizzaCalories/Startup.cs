using System;
using System.Collections.Generic;
using System.Globalization;

namespace Problem5_PizzaCalories
{
    public class Startup
    {
        private static List<string> messages = new List<string>();


        public static void Main()
        {
            Dough dought = new Dough();
            CultureInfo culture = new CultureInfo("en-US", false);


            while (true)
            {
                try
                {
                    var inputLineElements = Console.ReadLine().Trim().Split();

                    if (inputLineElements[0] == "END")
                    {
                        break;
                    }

                    if (inputLineElements[0] == "Dough")
                    {
                        dought = new Dough(double.Parse(inputLineElements[inputLineElements.Length - 1]));

                        for (int i = 1; i < inputLineElements.Length - 1; i++)
                        {
                            dought.AddDought(inputLineElements[i]);
                        }

                        AddMessage(dought.GetCalories().ToString("0.00", culture));
                    }

                    if (inputLineElements[0] == "Topping")
                    {
                        Topping topping = new Topping(inputLineElements[1], double.Parse(inputLineElements[2]));
                        AddMessage(topping.GetCalories().ToString("0.00", culture));

                    }
                }
                catch (Exception ex)
                {

                    messages.Add(ex.Message);
                }

            }

            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }

        public static void AddMessage(string message)
        {
            Startup.messages.Add(message);
        }
    }
}
