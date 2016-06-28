using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Problem9_PizzaTime
{
    public class Program
    {
        public static void Main()
        {

            List<Pizza> pizzas=new List<Pizza>();
            var inputLIne = Console.ReadLine().Trim().Split();

            foreach (var element in inputLIne)
            {
                string regexResult = Regex.Match(element, @"(^\d*)").Value;
                int group = int.Parse(regexResult);
                string pizzaName = element.Substring(regexResult.Length);
                pizzas.Add(new Pizza(pizzaName,group));
            }

            var result = pizzas.GroupBy(g=>g.@group).OrderBy(g=>g.Key);

            foreach (var group in result)
            {
                int count = 0;
                Console.Write($"{group.Key} - ");
                foreach (var pizza in group)
                {
                    if (count>0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(pizza.name);
                    count++;
                }
                Console.WriteLine();
            }
        }
    }

    public class Pizza
    {
        public string name;
        public int group;

        public Pizza(string name, int group)
        {
            this.name = name;
            this.@group = group;
        }
    }
}
