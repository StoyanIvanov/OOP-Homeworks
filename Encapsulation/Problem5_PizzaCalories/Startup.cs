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
                       
                    }

                    if (inputLineElements[0] == "Topping")
                    {
                       
                    }

                    if (inputLineElements[0]== "Pizza")
                    {
                        string pizzaName = inputLineElements[1];
                        int toppingNumber = int.Parse(inputLineElements[2]);

                        var doughElements = Console.ReadLine().Trim().Split();
                        dought = new Dough(double.Parse(doughElements[doughElements.Length - 1]));
                        for (int i = 1; i < doughElements.Length - 1; i++)
                        {
                            dought.AddDought(doughElements[i]);
                        }
                        //AddMessage(dought.GetCalories().ToString("0.00", culture));

                        Pizza pizza = new Pizza(pizzaName, dought);

                        for (int i = 0; i < toppingNumber; i++)
                        {
                            var toppingElements = Console.ReadLine().Trim().Split();
                            Topping topping = new Topping(toppingElements[1], double.Parse(toppingElements[2]));
                            //AddMessage(topping.GetCalories().ToString("0.00", culture));
                            pizza.AddTopping(topping);
                        }

                        AddMessage($"{pizza.Name} - {pizza.TotalCalories().ToString("0.00", culture)} Calories.");
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
