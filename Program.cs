using employee_salary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using employee_salary_app;
using System.Threading.Tasks;

namespace employee_salary_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<employee> emp = new List<employee>();
            emp.Add(new employee { employee_id = 1, employee_name = "Tanu", employe_age = 25, employee_salary = 600 });
            emp.Add(new employee { employee_id = 2, employee_name = "Anu", employe_age = 29, employee_salary = 1000 });
            emp.Add(new employee { employee_id = 3, employee_name = "Renju", employe_age = 32, employee_salary = 1500 });

            Console.WriteLine("Employee Salary Details:");

            foreach (var employee in emp)
            {
                employee.displayemployee();
            }

            Console.WriteLine("Please select one employee (1, 2, or 3):");
            string choice = Console.ReadLine();

            employee selectedEmployee = null;
           

            switch (choice)
            {
                case "1":
                    selectedEmployee = emp[0];
                    break;
                case "2":
                    selectedEmployee = emp[1];
                    break;
                case "3":
                    selectedEmployee = emp[2];
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    return;
            }

            selectedEmployee.displayemployee_details();

            Console.WriteLine("Please enter the employee's present days:");
            selectedEmployee.PresentDays = Convert.ToInt32(Console.ReadLine());

            double totalSalary = selectedEmployee.CalculateTotalSalary();
            Console.WriteLine("The total salary for 1 month is:"+totalSalary);

            Console.ReadLine();
        }

            }
    }

