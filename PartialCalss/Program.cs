using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            emp.Salary = 100000;
            emp.Gender = "Male";
           
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}