using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DefiningClasses
{

    public class Startup
    {
        public class Car
        {
            private string model;
            private double fuelAmount;
            private double fuelCost;
            private int traveledDistance;

            public Car(string model, double fuelAmount, double fuelCost)
            {
                this.model = model;
                this.fuelAmount = fuelAmount;
                this.fuelCost = fuelCost;
                this.traveledDistance = 0;
            }

            public string Model
            {
                get { return model; }
                private set { model = value; }
            }

            public double Fuel
            {
                get { return fuelAmount; }
                private set { fuelAmount = value; }
            }

            public int TravelKilometers
            {
                get { return this.traveledDistance; }
                private set { this.traveledDistance = value; }
            }

            public bool Move(int kilometers)
            {
                if (fuelCost * kilometers <= fuelAmount)
                {
                    fuelAmount = fuelAmount - (fuelCost * kilometers);
                    traveledDistance = traveledDistance + kilometers;
                    return true;
                }

                return false;
            }

            public string Print()
            {

                return this.Model + " " + string.Format("{0:0.00}", this.fuelAmount) + " " + this.traveledDistance.ToString();
            }
        }

        public static void Main()
        {
            int inputCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<string> invalides = new List<string>();
            for (int i = 0; i < inputCars; i++)
            {
                var input = Console.ReadLine().Trim().Split();
                cars.Add(new Car(input[0], double.Parse(input[1], CultureInfo.InvariantCulture), double.Parse(input[2], CultureInfo.InvariantCulture)));
            }

            while (true)
            {
                var command = Console.ReadLine().Trim().Split();
                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Drive")
                {
                    var car = cars.Select(c => c).First(c => c.Model == command[1]);
                    if ((bool)!car?.Move(int.Parse(command[2])))
                    {
                        invalides.Add("Insufficient fuel for the drive");
                    }
                }
            }

            foreach (var invalide in invalides)
            {
                Console.WriteLine(invalide);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Print()}");
            }

        }
    }

}
