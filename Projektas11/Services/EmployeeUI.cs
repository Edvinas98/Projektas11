using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektas11.Contracts;
using Projektas11.Models;

namespace Projektas11.Services
{
    public class EmployeeUI : IEmployeeUI
    {
        private IEmployeeService _employeeService;
        public EmployeeUI(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public void LaunchMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Show all employees");
                Console.WriteLine("2. Add employees");
                Console.WriteLine("0. Stop the application");
                Console.Write("Choose action: ");
                GetInput(out string input);
                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine();
                            foreach (IEmployee employee in _employeeService.GetAllEmployees())
                            {
                                Console.WriteLine(employee);
                            }
                            break;
                        case "2":
                            Console.Write("Enter how many employess you want to add: ");
                            GetInput(out int addCount);
                            Console.WriteLine();
                            for (int i = 1; i <= addCount; i++)
                            {
                                Console.WriteLine($"Employee nr. {i}");
                                Console.Write("Enter if this employee is a manager (true/false): ");
                                GetInput(out bool bIsManager);
                                Console.Write("Enter name: ");
                                GetInput(out string name);
                                Console.Write("Enter age: ");
                                GetInput(out byte age);
                                if (bIsManager)
                                {
                                    Console.Write("Enter how many employees this manager has: ");
                                    GetInput(out int employeeCount);
                                    Console.WriteLine(_employeeService.AddEmployee(new Manager(name, age, employeeCount), true));
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine(_employeeService.AddEmployee(new Employee(name, age), true));
                                    Console.WriteLine();
                                }
                            }
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
            }
        }

        public void GetInput(out string input)
        {
            while (true)
            {
                input = Console.ReadLine() ?? string.Empty;
                if (input != "")
                    return;
                else
                    Console.Write("Error, try entering again: ");
            }
        }

        public void GetInput(out byte input)
        {
            while (true)
            {
                if (!byte.TryParse(Console.ReadLine(), out input) || input <= 0)
                    Console.Write("Error, try entering again: ");
                else
                    return;
            }
        }

        public void GetInput(out bool input)
        {
            while (true)
            {
                if (!bool.TryParse(Console.ReadLine(), out input))
                    Console.Write("Error, try entering again: ");
                else
                    return;
            }
        }

        public void GetInput(out int input)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out input) || input < 1)
                    Console.Write("Error, try entering again: ");
                else
                    return;
            }
        }
    }
}
