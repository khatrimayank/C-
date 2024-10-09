using System;

namespace Learning_C_Sharp
{
    class Car
    {
        public string color;
        public int weight = 250;
        public void Drive()
        {
            Console.WriteLine("driving car");
        }
    }

    namespace other
    {
        class Cars
        {
            public string color;
            public int weight = 250;
            public void Brake()
            {
                Console.WriteLine("Stop the car");
            }
        }

        class main
        {
            static void Main(string[] args)
            {

                Car Volvo = new Car();
                Volvo.color = "Blue";

                Volvo.Drive();

                Console.WriteLine($"{Volvo.weight}");

                Cars obj = new Cars();

                obj.color = "Red";

                obj.Brake();

            }
        }
        
    }
    
}
