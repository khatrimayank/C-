using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string ComputerName
        {
            get
            {
                return System.Environment.MachineName;
            }
        }
        public void Insert()
        {
            //Logic to Insert the Country Details into the Database
            //ComputerName property tells from which computer the Record is being Inserted
        }
    }
}
