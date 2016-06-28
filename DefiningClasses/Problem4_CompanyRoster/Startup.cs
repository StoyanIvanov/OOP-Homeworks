
using System.Globalization;

namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }

    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email = "n/a";
        private int age = -1;

        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Postion
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

    }

    public class Startup
    {
        public static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < inputLines; i++)
            {
                var inputElements = Console.ReadLine().Trim().Split();
                Employee employee = new Employee(inputElements[0], double.Parse(inputElements[1], CultureInfo.InvariantCulture), inputElements[2], inputElements[3]);
                int age;
                if (inputElements.Length == 5)
                {
                    if (int.TryParse(inputElements[4], out age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = inputElements[4];
                    }

                }
                else if (inputElements.Length == 6)
                {

                    employee.Email = inputElements[4];
                    employee.Age = int.Parse(inputElements[5]);
                }

                employees.Add(employee);
            }



            var maxDepartment = employees
                .GroupBy(e => e.Department)
                .Select(s => new
                {
                    Department = s.Key,
                    SalaryAvg = s.Average(x => x.Salary)
                })
                .OrderByDescending(d => d.SalaryAvg)
                .First();

            var result = employees.Where(e => e.Department == maxDepartment.Department).Select(e => e).OrderByDescending(p => p.Salary);

            Console.WriteLine($"Highest Average Salary: {maxDepartment.Department}");

            foreach (var employee in result)
            {
                Console.WriteLine($"{employee.Name} {string.Format("{0:0.00}", employee.Salary)} {employee.Email} {employee.Age}");
            }


        }
    }

}
