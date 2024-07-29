using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas11.Models;
using Projektas11.Services;

namespace Projektas11.Contracts
{
    public interface IEmployeeUI
    {
        /// <summary>
        /// Launch Menu that lets user to view all employees and to add more employees
        /// </summary>
        void LaunchMenu();
        /// <summary>
        /// Gets user's string input
        /// </summary>
        /// <param name="input"></param>
        void GetInput(out string input);
        /// <summary>
        /// Gets user's byte input
        /// </summary>
        /// <param name="input"></param>
        void GetInput(out byte input);
        /// <summary>
        /// Gets user's bool input
        /// </summary>
        /// <param name="input"></param>
        void GetInput(out bool input);
        /// <summary>
        /// Gets user's int input
        /// </summary>
        /// <param name="input"></param>
        void GetInput(out int input);
    }
}
