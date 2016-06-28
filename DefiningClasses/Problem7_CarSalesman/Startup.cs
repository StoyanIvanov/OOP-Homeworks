using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Problem7_CarSalesman
{
    public class Startup
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars=new List<Car>();
            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var elements = Console.ReadLine().Trim().Split();
                var model = elements[0];
                var power = int.Parse(elements[1]);
                var displacement = 0;
                var efficiency = "";
                if (elements.Length > 3)
                {
                    displacement = int.Parse(elements[2]);
                    efficiency = elements[3];
                }

                if (elements.Length==3)
                {
                    int parseInt;
                    if (int.TryParse(elements[2], out parseInt))
                    {
                        displacement = int.Parse(elements[2]);
                    }
                    else
                    {
                        efficiency = elements[2];
                    }

                }

                engines.Add(new Engine(model, power, displacement, efficiency));
            }

            inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var elements = Console.ReadLine().Trim().Split();
                var model = elements[0];
                var engine = engines.FirstOrDefault(e => e.Model == elements[1]);
                var weight = "";
                var color = "";
                if (elements.Length>3)
                {
                    weight = elements[2];
                    color = elements[3];
                }

                if (elements.Length==3)
                {
                    int parseInt;
                    if (int.TryParse(elements[2], out parseInt))
                    {
                        weight = elements[2];
                    }
                    else
                    {
                        color = elements[2];
                    }

                }

                cars.Add(new Car(model,engine,weight,color));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");

            }
        }
    }
}
