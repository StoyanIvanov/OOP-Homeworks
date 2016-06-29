using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Problem1_ClassBox
{
    public class Startup
    {
        public static void Main()
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            Box box=new Box(lenght,width,height);

            Console.WriteLine($"Surface Area - { box.SurfaceArea().ToString("0.00", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralArea().ToString("0.00", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume - {box.Volume().ToString("0.00", CultureInfo.InvariantCulture)}");



        }
    }
}
