using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas11.Models
{
    public class Manager : Employee
    {
        public int NumberOfEmployees { get; set; }

        public Manager(string name, byte age, int numberOfEmployees) : base(name, age)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override void WriteData()
        {
            using (StreamWriter sw = new StreamWriter("Employees.csv", true))
            {
                sw.WriteLine($"{Name},{Age},{NumberOfEmployees}");
            }
        }

        public override string ToString()
        {
            return $"Manager {Name}, Age: {Age}, Employee count: {NumberOfEmployees}";
        }
    }
}
