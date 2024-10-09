using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

        private string MachineName = "";
        public Customer()
        {
            MachineName = CommonTask.ComputerName;
        }
        public bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }

            return false;
        }
        public void Insert()
        {
            if (IsEmpty(CustomerCode) && IsEmpty(CustomerName))
            {
                //Insert the data
            }
        }
    }
}
