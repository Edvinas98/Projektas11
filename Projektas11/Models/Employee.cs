using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Projektas11.Contracts;
using static System.Net.Mime.MediaTypeNames;

namespace Projektas11.Models
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public Employee(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public List<string> ReadData()
        {
            List<string> employees = new List<string>();

            using (StreamReader sr = new StreamReader("Employees.csv"))
            {
                while (!sr.EndOfStream)
                    employees.Add(sr.ReadLine() ?? string.Empty);
            }

            return employees;
        }

        public virtual void WriteData()
        {
            using (StreamWriter sw = new StreamWriter("Employees.csv", true))
            {
                sw.WriteLine($"{Name},{Age}");
            }
        }

        public override string ToString()
        {
            return $"Employee {Name}, Age: {Age}";
        }
    }
}
