using System;
using System.Linq;

namespace Problem10_Family_Tree
{
    public class Startup
    {
        public static void Main()
        {
            var person = new Person();
            var firstInputLine = Console.ReadLine();

            //Only Person Names
            if (firstInputLine.Split('/').Length == 1)
            {
                var names = firstInputLine.Split();
                person.AddNames(names[0], names[1]);
            }
            //Only Date
            else if (firstInputLine.Split('/').Length > 1)
            {
                person.AddBurthDate(firstInputLine);
            }


            while (true)
            {
                var inputLine = Console.ReadLine().Trim().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);


                if (inputLine[0] == "End")
                {
                    break;
                }

                //Update Data
                if (inputLine.Length == 1)
                {
                    var elements = inputLine[0].Split();
                    person.UpdateData(elements[0], elements[1], elements[2]);
                }

                //Date - Date
                if (inputLine.Length == 2 && inputLine[0].Contains("/") && inputLine[1].Contains("/"))
                {
                    person.CheckTwoDates(inputLine[0], inputLine[1]);
                }

                //Date - Name
                if (inputLine.Length == 2 && inputLine[0].Contains("/")  && !inputLine[1].Contains("/"))
                {
                    person.CheckDateAndName(inputLine[0], inputLine[1]);
                }

                //Name - Date
                if (inputLine.Length == 2 && !inputLine[0].Contains("/") && inputLine[1].Contains("/"))
                {
                    person.CheckNameAndData(inputLine[0], inputLine[1]);
                }

                //Name - Name
                if (inputLine.Length == 2 && !inputLine[0].Contains('/') && !inputLine[1].Contains('/'))
                {
                    person.CheckTwoNames(inputLine[0], inputLine[1]);
                }



            }

            Console.WriteLine($"{person.Names} {person.BurthDate}");
            Console.WriteLine("Parents:");
            foreach (var parent in person.Parents)
            {
                Console.WriteLine($"{parent.Names} {parent.BurthDate}");
            }
            Console.WriteLine("Children:");
            foreach (var children in person.Childrens)
            {
                Console.WriteLine($"{children.Names} {children.BurthDate}");
            }
        }
    }
}
