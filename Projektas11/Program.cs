using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas11.Contracts;
using Projektas11.Services;

namespace Projektas11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService employeeService = new EmployeeService();
            IEmployeeUI employeeUI = new EmployeeUI(employeeService);
            employeeUI.LaunchMenu();
        }
    }
}
