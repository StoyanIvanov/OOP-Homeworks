using System;

namespace Problem1_Students
{
    public class Startup
    {
        public class Student
        {
            private string name;
            private static int numberOfStudents=0;

            public Student(string name)
            {
                this.name = name;
                numberOfStudents++;
            }

            public static int GetNumberOfStudents()
            {
                return numberOfStudents;
            }
        }

        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }

                Student student=new Student(input);
            }

            Console.WriteLine(Student.GetNumberOfStudents());
        }
    }
}
