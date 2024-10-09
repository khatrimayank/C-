using System;

namespace Learning_C_Sharp
{
    class RefAndOut
    {
        public void Ref(ref int age)
        {
            Console.WriteLine($"ref_age={age}");
            age += 10;
            Console.WriteLine($"ref_age={age}");
        }

        public void Normal(int age1)
        {
            Console.WriteLine($"normal_age1={age1}");
            age1 += 10;
            Console.WriteLine($"normal_age1={age1}");
        }

        public void Out(out int age2)
        {
            age2 = 20;
            Console.WriteLine($"out_age={age2}");
        }

        public static void Main(string[] args)
        {
            int age = 10;
            int age1 = 20;
            int age2;

            Console.WriteLine($"Initial values:");
            Console.WriteLine($"ref_age={age}");
            Console.WriteLine($"normal_age1={age1}");
            Console.WriteLine($"out_age=uninitialized\n");

            RefAndOut obj = new RefAndOut();

            obj.Ref(ref age);
            obj.Normal(age1);
            obj.Out(out age2);

            Console.WriteLine($"Values after methods:");
            Console.WriteLine($"ref_age={age}");
            Console.WriteLine($"normal_age1={age1}");
            Console.WriteLine($"out_age={age2}");
        }
    }
}
