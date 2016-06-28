using System;
using System.Collections.Generic;

namespace Problem5_AnimalClinic
{
    public class Startup
    {
        public static void Main()
        {
            Dictionary<int, Animal> patients = new Dictionary<int, Animal>();

            while (true)
            {
                var inputLineElements = Console.ReadLine().Trim().Split();
                if (inputLineElements[0] == "End")
                {
                    break;
                }
                Animal animal = new Animal(inputLineElements[0], inputLineElements[1]);
                int animalID = AnimalClinic.AddPacient(inputLineElements[2]);
                patients.Add(animalID, animal);
            }

            var hospitalizePacients = AnimalClinic.GetPacient();

            foreach (var pacient in hospitalizePacients)
            {
                if (pacient.Value== "heal")
                {
                    Console.WriteLine($"Patient {pacient.Key}: [{patients[pacient.Key].Name} ({patients[pacient.Key].Bread})] has been healed!");
                }

                if (pacient.Value == "rehabilitate")
                {
                    Console.WriteLine($"Patient {pacient.Key}: [{patients[pacient.Key].Name} ({patients[pacient.Key].Bread})] has been rehabilitated!");
                }
            }

            Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitedAnimalsCount}");

            var inputFilter = Console.ReadLine();

            foreach (var pacient in hospitalizePacients)
            {
                if (pacient.Value == inputFilter)
                {
                    Console.WriteLine($"{patients[pacient.Key].Name} {patients[pacient.Key].Bread}");
                }
            }

        }
    }
}
