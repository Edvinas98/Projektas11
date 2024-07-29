using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas11.Models;

namespace Projektas11.Contracts
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Adds employee to the list. Returns result of the method via a string
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <param name="bUpdateFile">if true, writes the employee info to file</param>
        /// <returns></returns>
        string AddEmployee(IEmployee newEmployee, bool bUpdateFile);
        /// <summary>
        /// Returns a list of employees
        /// </summary>
        /// <returns></returns>
        List<IEmployee> GetAllEmployees();
        /// <summary>
        /// Checks if there is an employee with such name
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns></returns>
        bool CheckEmployee(IEmployee newEmployee);
        /// <summary>
        /// Initiates reading of employee list in a specified file and updates the employee list with it
        /// </summary>
        void ReadEmployees();
    }
}
