using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Problem4_ShoppingSpree
{
    public class Startup
    {
        private static List<string> outputStrings = new List<string>();
        public static void Main()
        {
            try
            {
                Dictionary<string, Person> persons = new Dictionary<string, Person>();
                Dictionary<string, Product> products = new Dictionary<string, Product>();

                var peoples = Console.ReadLine().Trim().Split(';');
                var inputProducts = Console.ReadLine().Trim().Split(';');

                foreach (var people in peoples)
                {
                    if (!string.IsNullOrEmpty(people))
                    {
                        var peopleElements = people.Trim().Split('=');
                        var peopleName = peopleElements[0];
                        var peopleMoney = double.Parse(peopleElements[1]);
                        Person person = new Person(peopleName, peopleMoney);
                        if (!persons.ContainsKey(peopleName))
                        {
                            persons.Add(peopleName, person);
                        }
                        else
                        {
                            persons[peopleName] = person;
                        }
                    }

                }

                foreach (var product in inputProducts)
                {
                    if (!string.IsNullOrEmpty(product))
                    {
                        var productElements = product.Trim().Split('=');
                        var productName = productElements[0];
                        var productCost = double.Parse(productElements[1]);
                        Product shopProduct = new Product(productName, productCost);
                        if (!products.ContainsKey(productName))
                        {
                            products.Add(productName, shopProduct);
                        }
                        else
                        {
                            products[productName] = shopProduct;
                        }
                    }

                }

                while (true)
                {
                    var inputCommand = Console.ReadLine().Trim().Split();
                    if (inputCommand[0] == "END")
                    {
                        break;
                    }

                    if (persons.ContainsKey(inputCommand[0]) && products.ContainsKey(inputCommand[1]))
                    {
                        if (persons[inputCommand[0]].BayProduct(products[inputCommand[1]]))
                        {
                            outputStrings.Add($"{inputCommand[0]} bought {inputCommand[1]}");
                        }
                        
                    }
                }

                foreach (var outputString in outputStrings)
                {
                    Console.WriteLine(outputString);
                }

                foreach (var person in persons)
                {
                    if (person.Value.Products.Count > 0)
                    {
                        string stringLine = person.Value.Name + " - ";
                        int index = 0;
                        foreach (var product in person.Value.Products)
                        {
                            if (index > 0)
                            {
                                stringLine += ", ";
                            }
                            index++;
                            stringLine += product.Name;
                        }
                        Console.WriteLine(stringLine);
                    }
                    else
                    {
                        Console.WriteLine($"{person.Value.Name} - Nothing bought");
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public static void PrintConsoleMessage(string message)
        {
            outputStrings.Add(message);
        }
    }
}
