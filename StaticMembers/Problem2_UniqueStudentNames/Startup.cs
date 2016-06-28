using System;
using System.Collections.Generic;

namespace Problem2_UniqueStudentNames
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public string Name {
            get { return name; }
            private set { }
        }    
    }

    public class StudentGroup
    {
        private HashSet<string> uniqueStudents;
        private static int count=0;

        public StudentGroup()
        {
            uniqueStudents=new HashSet<string>();
        }

        public void AddStudent(Student student)
        {
            if (!uniqueStudents.Contains(student.Name))
            {
                this.uniqueStudents.Add(student.Name);
                count++;
            }
        }

        public static int GetUniqueStudents()
        {
            return count;
        }
    }

    public class Startup
    {
        public static void Main()
        {
            StudentGroup group=new StudentGroup();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine=="End")
                {
                    break;
                    ;
                }
                Student student=new Student(inputLine);
                group.AddStudent(student);
            }

            Console.WriteLine(StudentGroup.GetUniqueStudents());
        }
    }
}
