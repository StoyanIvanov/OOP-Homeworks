using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_RawData
{
    class Startup
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int commandLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandLines; i++)
            {
                var elements = Console.ReadLine().Trim().Split();
                var carName = elements[0];
                var engine = new Engine(int.Parse(elements[1]), int.Parse(elements[2]));
                var cargo = new Cargo(int.Parse(elements[3]), elements[4]);
                var tire1 = new Tire(double.Parse(elements[5], CultureInfo.InvariantCulture), int.Parse(elements[6]));
                var tire2 = new Tire(double.Parse(elements[7], CultureInfo.InvariantCulture), int.Parse(elements[8]));
                var tire3 = new Tire(double.Parse(elements[9], CultureInfo.InvariantCulture), int.Parse(elements[10]));
                var tire4 = new Tire(double.Parse(elements[11], CultureInfo.InvariantCulture), int.Parse(elements[12]));

                cars.Add(new Car(carName, engine, cargo, tire1, tire2, tire3, tire4));
            }

            var commandLine = Console.ReadLine();

            if (commandLine == "fragile")
            {
                var result = cars
                    .Select(c => c)
                    .Where(c => c.Cargo.Type == commandLine && c.Tires.GroupBy(t => t.Presure).Select(t => t.Key).Min() < 1)
                    .ToList();

                foreach (var car in result)
                {
                    Console.WriteLine($"{car.Name}");
                }

            }

            if (commandLine == "flamable")
            {
                var result = cars
                    .Select(c => c)
                    .Where(c => c.Cargo.Type == commandLine && c.Engine.Power > 250)
                    .ToList();

                foreach (var car in result)
                {
                    Console.WriteLine($"{car.Name}");
                }

            }

        }
    }
}
