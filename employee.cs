using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace employee_salary
{
    internal class employee
    {
     public int employee_id { get; set; }
        public string employee_name { get; set; }
        public int employe_age { get; set; }
        public double employee_salary { get; set; }
        public int PresentDays { get; set; }
      
          public void displayemployee()
        {
          Console.WriteLine($"ID: {employee_id}, Name: {employee_name}");
       }
        public void displayemployee_details()
        {
            Console.WriteLine($"ID: {employee_id}, Name: {employee_name}, Age: {employe_age},Salary for one day: {employee_salary},");
        }
        public double CalculateTotalSalary()
        {
            return employee_salary * PresentDays;
        }
       
    }
    
}
