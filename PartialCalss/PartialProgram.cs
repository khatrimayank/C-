using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    class PartialProgram
    {
        static void Main(string[] args)
        {
   
            PartialEmployee emp = new PartialEmployee();

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

