using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_C_Sharp
{
    class Properties
    {
        
        public string Name
        { get; set; }

        public string Addr
        { get; set; }
        public int Age
        { get; set; }

        

    }

    public class Master
    {

        public static void Main(string[] args)
        {

            Properties obj = new Properties();

            obj.Name = "Mayank";

            obj.Age = 21;

            obj.Addr = "dssfdf";

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.Addr);

        }
    }
}
