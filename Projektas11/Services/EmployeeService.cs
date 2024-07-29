using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas11.Contracts;
using Projektas11.Models;

namespace Projektas11.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<IEmployee> Employees { get; set; }


        public EmployeeService()
        {
            Employees = new List<IEmployee>();
            ReadEmployees();
        }

        public string AddEmployee(IEmployee newEmployee, bool bUpdateFile)
        {
            bool bFound = false;

            foreach (IEmployee employee in Employees)
            {
                if (CheckEmployee(newEmployee))
                    bFound = true;
            }
            if (bFound)
                return "Employee with such name is already in the list!";

            Employees.Add(newEmployee);
            if(bUpdateFile)
                newEmployee.WriteData();
            return "Employee was added successfully";
        }

        public List<IEmployee> GetAllEmployees()
        {
            return Employees;
        }

        public bool CheckEmployee(IEmployee newEmployee)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.Name == ((Employee)newEmployee).Name)
                    return true;
            }
            return false;
        }

        public void ReadEmployees()
        {
            IEmployee fakeEmployee = new Employee("Fake",0);
            List<string> data = fakeEmployee.ReadData();

            if(data.Count > 0)
            {
                foreach(string str in data)
                {
                    if(str != "")
                    {
                        string[] values = str.Split(',');
                        if (values.Length > 1)
                        {
                            if (!byte.TryParse(values[1], out byte byteValue))
                                continue;
                            if (values.Length == 3)
                            {
                                if (!int.TryParse(values[2], out int intValue))
                                    continue;
                                AddEmployee(new Manager(values[0], byteValue, intValue), false);
                            }
                            else
                                AddEmployee(new Employee(values[0], byteValue), false);
                        }
                    }
                }
            }
        }
    }
}
