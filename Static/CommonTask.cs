using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    public static class CommonTask
    {
        public static bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return true;
            }

            return false;
        }

        public static string GetComputerName()
        {
            return System.Environment.MachineName;
            
        }
    }
}


/*
Once you make the class static, then you cannot apply any kind of OOPs Principles even you cannot use 
the new keyword with the static class to create an instance 
rather you need to invoke the IsEmpty method and ComputerName property by using the class name directly. 
Internally only one instance of the static class gets created by CLR as soon as the class execution 
starts and the same single instance will be served by all clients

    How is the Static Class Instantiated in C#?
We cannot apply any OOPs principles to the static class like inheritance, polymorphism, encapsulation, 
and abstraction. But in the end, it is a class. And at least to use a class it has to be instantiated.
Why because once it is instantiated. then only the static members get memory allocation. 
Until and unless the memory is not allocated, we cannot access them. So, 
if the static class is not instantiated then we cannot invoke the methods and properties 
that are present inside the static class. Now let us see how the instantiation takes place internally 
of a static class i.e. in our example, it is the CommonTask class.

The CLR (Common Language Runtime) internally will create only one instance of the CommonTask class 
irrespective of how many times they called from the Customer and CountryMaster class. 
And it is going to be created for the first time when we use consume the CommonTask class.

******Now, please remove the IsEmpty() method from the Customer class and 
* the ComputerName property from the CountryMaster class. 
* Now both the logic which violates the OOPs principle has been moved to the CommonTask class.
*/
