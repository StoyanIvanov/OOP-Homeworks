using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Problem7__ImmutableList
{
    public class Startup
    {
        public static void Main()
        {
            Type immutableList = typeof(ImmutableList);
            FieldInfo[] fields = immutableList.GetFields();
            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[0].ReturnType.Name);
            }

        }
    }

    public class ImmutableList
    {
        public List<int> intCollection;

        public ImmutableList()
        {
            intCollection = new List<int>();
        }

        public ImmutableList Return()
        {
            return new ImmutableList();
        }

    }
}
