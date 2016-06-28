using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Problem8_Car
{
    public class Startup
    {

        public static void Main()
        {
            List<string> commands = new List<string>();
            var inputCar = Console.ReadLine().Trim().Split();
            Car car = new Car(int.Parse(inputCar[0]), double.Parse(inputCar[1]), double.Parse(inputCar[2]));

            while (true)
            {
                var command = Console.ReadLine().Trim().Split();
                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "Travel")
                {
                    car.Travel(double.Parse(command[1]));
                }

                if (command[0] == "Refuel")
                {
                    car.Refuel(double.Parse(command[1]));
                }


                if (command[0] == "Distance")
                {
                    commands.Add(car.Distance());
                }

                if (command[0] == "Time")
                {
                    commands.Add(car.Time());
                }

                if (command[0] == "Fuel")
                {
                    commands.Add(car.Fuel());
                }

            }

            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
        }
    }

    public class Car
    {
        private int speed;
        private double fuel;
        private double fuelEconomy;
        private double distance;
        private double minutes;
        private int hourse;

        public Car(int speed, double fuel, double fuelEconomy)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEconomy = fuelEconomy;
        }

        public void Travel(double travel)
        {
            if (((travel / 100) * fuelEconomy <= fuel) && travel > 0)
            {
                this.distance += travel;
                minutes = minutes + ((travel / speed) * 60);
                fuel = fuel - ((travel / 100) * fuelEconomy);
            }
            else
            {
                travel = ((100 / fuelEconomy) * fuel);
                this.distance += travel;
                minutes = minutes + ((travel / speed) * 60);
                fuel = fuel - ((travel / 100) * fuelEconomy);
            }
        }

        public string Distance()
        {
            return $"Total distance: {distance.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)} kilometers";
        }

        public string Time()
        {
            string hourse = (this.minutes / 60).ToString().Split('.')[0];
            string minutes = "0";
            try
            {
                minutes = (double.Parse((this.minutes / 60).ToString().Split('.')[1]) * 60).ToString();
            }
            catch (Exception)
            {

            }

            return $"Total time: {hourse} hours and {minutes} minutes";
        }

        public string Fuel()
        {
            return $"Fuel left: {fuel.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)} liters";
        }

        public void Refuel(double fuel)
        {
            if (fuel > 0)
            {
                this.fuel += fuel;
            }

        }
    }
}
