using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_AnimalClinic
{
    public class AnimalClinic
    {
        private static int patientId = 0;
        public static int healedAnimalsCount;
        public static int rehabilitedAnimalsCount;
        private static Dictionary<int, string> manipulation=new Dictionary<int, string>();

        public static int AddPacient(string manipulation)
        {
            patientId++;

            if (manipulation == "heal")
            {
                healedAnimalsCount++;
                AnimalClinic.manipulation.Add(patientId, "heal");
            }
            else
            {
                AnimalClinic.manipulation.Add(patientId, "rehabilitate");
                rehabilitedAnimalsCount++;
            }

            return patientId;
        }

        public static Dictionary<int, string> GetPacient()
        {
            return manipulation;
        }
    }
}
